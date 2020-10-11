using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Commands.CreateGroup
{
    public class CreateGroupCommand : IRequest<Result<GroupResponse>>
    {
        public string TourId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, Result<GroupResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGroupHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupResponse>> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var newGroup = _mapper.Map<E.Group>(request);

            /** Make sure tourId is existed **/
            var tour = await _context.Tours.SingleOrDefaultAsync(
                    t => t.Id == newGroup.TourId &&
                    t.IsDeleted == false
            );
            if (tour == null)
            {
                return new Result<GroupResponse>(
                    new BadRequestException(
                        new ApiError("Tour is not existed (tourId)"))
                );
            }

            /** Make sure name is unique in 1 tour **/
            var existGroup = await _context.Group.SingleOrDefaultAsync(
                g => g.TourId == newGroup.TourId &&
                g.Name == newGroup.Name &&
                g.IsDeleted == false
            );
            if (existGroup != null)
            {
                return new Result<GroupResponse>(
                    new BadRequestException(
                        new ApiError("This name already exists, please try another name"))
                );
            }

            await _context.Group.AddAsync(newGroup);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<GroupResponse>(
                    _mapper.Map<GroupResponse>(newGroup)
                );
            }

            return new Result<GroupResponse>(
                new BadRequestException(
                    new ApiError("Create group failed, please try again"))
            );
        }
    }
}