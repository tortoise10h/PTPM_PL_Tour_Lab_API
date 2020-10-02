using AutoMapper;
using src.CQRS.Tour.Commands.UpdateTour;
using src.Entities;

namespace src.MapperProfiles
{
    public class CommandModelToEntityProfile : Profile
    {
        public CommandModelToEntityProfile()
        {
            CreateMap<UpdateTourCommand, Tour>();
        }
    }
}