using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.GroupDetail.Commands.UpdateGroupDetail
{
    public class UpdateGroupDetailCommand : IRequest<Result<GroupDetailResponse>>
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class UpdateGroupDetailHandler : IRequestHandler<UpdateGroupDetailCommand, Result<GroupDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateGroupDetailHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupDetailResponse>> Handle(UpdateGroupDetailCommand request, CancellationToken cancellationToken)
        {
            var groupDetail = await _context.GroupDetail.SingleOrDefaultAsync(
                gd => gd.Id == request.Id &&
                gd.IsDeleted == false
            );

            if (groupDetail == null)
            {
                return new Result<GroupDetailResponse>(
                    new NotFoundException()
                );
            }

            _mapper.Map<UpdateGroupDetailCommand, E.GroupDetail>(request, groupDetail);
            _context.GroupDetail.Update(groupDetail);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GroupDetailResponse>(
                    _mapper.Map<GroupDetailResponse>(groupDetail)
                );
            }

            return new Result<GroupDetailResponse>(
                new BadRequestException(new ApiError("Update Group Detail failed, please try again"))
            );
        }
    }
}