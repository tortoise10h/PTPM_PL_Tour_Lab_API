using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Commands.UpdateGroup
{
    public class UpdateGroupCommand : IRequest<Result<GroupResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public GroupStatusEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class UpdateGroupHandler : IRequestHandler<UpdateGroupCommand, Result<GroupResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateGroupHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupResponse>> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.Id
                && g.IsDeleted == false
            );

            if (group == null)
            {
                return new Result<GroupResponse>(
                    new NotFoundException()
                );
            }

            if (group.Status == GroupStatusEnum.Done || group.Status == GroupStatusEnum.Canceled)
            {
                return new Result<GroupResponse>(
                    new BadRequestException(new ApiError("This group has been done or canceled"))
                );
            }

            _mapper.Map<UpdateGroupCommand, E.Group>(request, group);
            _context.Group.Update(group);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GroupResponse>(
                    _mapper.Map<GroupResponse>(group)
                );
            }

            return new Result<GroupResponse>(
                new BadRequestException(new ApiError("Update group failed, please try again"))
            );
        }
    }
}