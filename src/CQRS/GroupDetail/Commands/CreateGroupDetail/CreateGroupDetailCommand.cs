using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupDetail;
using E = src.Entities;
using src.Helpers;
using src.Entities;

namespace src.CQRS.GroupDetail.Commands.CreateGroupDetail
{
    public class CreateGroupDetailCommand : IRequest<Result<List<GroupDetailResponse>>>
    {
        public int GroupId { get; set; }
        public List<string> UserIds { get; set; }
    }

    public class CreateGroupDetailHandler : IRequestHandler<CreateGroupDetailCommand, Result<List<GroupDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateGroupDetailHandler(DataContext context, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Result<List<GroupDetailResponse>>> Handle(CreateGroupDetailCommand request, CancellationToken cancellationToken)
        {
            /** Make sure GroupId exist and status is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.GroupId
            );
            if (group == null)
            {
                return new Result<List<GroupDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Đoàn không tồn tại")
                    )
                );
            }
            if (group.Status != GroupStatusEnum.New)
            {
                return new Result<List<GroupDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Chỉ có thể thêm khách hàng khi trạng thái của đoàn là Mới")
                    )
                );
            }

            /** Make sure UserId exists and is unique **/
            var uniqueUserIds = request.UserIds.Distinct().ToList();
            var users = await _context.Users
                .Where(u => uniqueUserIds.Contains(u.Id))
                .ToListAsync();

            if (request.UserIds.Length() != uniqueUserIds.Count())
            {
                return new Result<List<GroupDetailResponse>>(
                    new BadRequestException(
                        new ApiError("User Id must be unique")
                    )
                );
            }

            if (uniqueUserIds.Count() != users.Count())
            {
                return new Result<List<GroupDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Some User Id does not exist")
                    )
                );
            }

            /** Make sure each User in Group 1 time **/
            var existUsers = await _context.GroupDetail
                .Where(gd => uniqueUserIds.Contains(gd.UserId))
                .ToListAsync();
            if (existUsers.Count() > 0)
            {
                return new Result<List<GroupDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Khách hàng đã tồn tại trong đoàn, vui lòng thử lại")
                    )
                );
            }

            /** Make sure UserRole is Customer **/
            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var role in userRoles)
                {
                    if (role != "Customer")
                    {
                        return new Result<List<GroupDetailResponse>>(
                            new BadRequestException(
                                new ApiError("User Role must be Customer")
                            )
                        );
                    }
                }
            }

            List<E.GroupDetail> groupDetails = new List<E.GroupDetail>();

            foreach (var user in users)
            {
                groupDetails.Add(
                    new E.GroupDetail
                    {
                        GroupId = request.GroupId,
                        UserId = user.Id
                    }
                );
            }

            _context.GroupDetail.AddRange(groupDetails);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<GroupDetailResponse>>(
                    _mapper.Map<List<GroupDetailResponse>>(groupDetails)
                );
            }

            return new Result<List<GroupDetailResponse>>(
                new BadRequestException(new ApiError("Thêm chi tiết đoàn thất bại, vui lòng thử lại"))
            );
        }
    }
}