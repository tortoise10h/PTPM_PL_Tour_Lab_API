using AutoMapper;
using src.CQRS.Tour.Commands.CreateTour;
using src.Entities;

namespace src.MapperProfiles
{
    public class RequestToEntityProfile : Profile
    {
        public RequestToEntityProfile()
        {
            CreateMap<CreateTourCommand, Tour>();
        }
    }
}
