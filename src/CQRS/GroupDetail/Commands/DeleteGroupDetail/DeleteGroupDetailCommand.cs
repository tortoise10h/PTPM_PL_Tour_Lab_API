using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.Helpers;

namespace src.CQRS.GroupDetail.Commands.DeleteGroupDetail
{
    public class DeleteGroupDetailCommand : IRequest<Result<GroupDetailResponse>>
    {
        public DeleteGroupDetailCommand(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
    }

    public class DeleteGroupDetailHandler : IRequestHandler<DeleteGroupDetailCommand, Result<GroupDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteGroupDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupDetailResponse>> Handle(DeleteGroupDetailCommand request, CancellationToken cancellationToken)
        {
            var groupDetail = await _context.GroupDetail.SingleOrDefaultAsync(
                gd => gd.Id == request.Id
            );

            if (groupDetail == null)
            {
                return new Result<GroupDetailResponse>(
                    new NotFoundException()
                );
            }

            /** Make sure GroupStatus is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == groupDetail.GroupId
                && g.IsDeleted == false
            );

            if (group.Status != GroupStatusEnum.New)
            {
                return new Result<GroupDetailResponse>(
                    new BadRequestException(
                        new ApiError("Can't add or remove Customer when GroupStatus is not New")
                    )
                );
            }

            _context.GroupDetail.Remove(groupDetail);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<GroupDetailResponse>(
                    _mapper.Map<GroupDetailResponse>(groupDetail)
                );
            }

            return new Result<GroupDetailResponse>(
                new BadRequestException(new ApiError("Delete GroupDetail failed, please try again"))
            );
        }
    }
}