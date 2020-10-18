using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.Helpers;

namespace src.CQRS.GroupDetail.Queries
{
    public class GetGroupDetailByIdQuery : IRequest<Result<GroupDetailResponse>>
    {
        public GetGroupDetailByIdQuery(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
    }


    public class GetGroupDetailByIdHandler : IRequestHandler<GetGroupDetailByIdQuery, Result<GroupDetailResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetGroupDetailByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupDetailResponse>> Handle(GetGroupDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var groupDetail = await _context.GroupDetail
                .Include(gd => gd.ApplicationUser)
                .SingleOrDefaultAsync(
                    g => g.Id == request.Id
                );

            if (groupDetail == null)
            {
                return new Result<GroupDetailResponse>(
                    new NotFoundException()
                );
            }

            return new Result<GroupDetailResponse>(
                _mapper.Map<GroupDetailResponse>(groupDetail)
            );
        }
    }
}