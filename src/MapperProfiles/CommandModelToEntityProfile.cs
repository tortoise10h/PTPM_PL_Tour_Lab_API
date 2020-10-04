using AutoMapper;
using src.CQRS.Tour.Commands.CreateTour;
using src.CQRS.Tour.Commands.UpdateTour;
using src.Entities;

namespace src.MapperProfiles
{
    public class CommandModelToEntityProfile : Profile
    {
        public CommandModelToEntityProfile()
        {
            CreateMap<CreateTourCommand, Tour>();
            CreateMap<UpdateTourCommand, Tour>();
        }
    }
}