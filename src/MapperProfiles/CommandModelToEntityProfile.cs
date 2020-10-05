using AutoMapper;
using src.CQRS.CostType.Commands.CreateCostType;
using src.CQRS.CostType.Commands.UpdateCostType;
using src.CQRS.Tour.Commands.CreateTour;
using src.CQRS.Tour.Commands.UpdateTour;
using src.CQRS.TourPrice.Commands.CreateTourPrice;
using src.CQRS.TourDetail.Commands.CreateTourDetail;
using src.CQRS.TouristAttraction.Commands.CreateTouristAttraction;
using src.CQRS.TouristAttraction.Commands.UpdateTouristAttraction;
using src.Entities;

namespace src.MapperProfiles
{
    public class CommandModelToEntityProfile : Profile
    {
        public CommandModelToEntityProfile()
        {
            CreateMap<CreateTourCommand, Tour>();
            CreateMap<UpdateTourCommand, Tour>();
            CreateMap<CreateTourPriceCommand, TourPrice>();
            CreateMap<CreateTouristAttractionCommand, TouristAttraction>();
            CreateMap<UpdateTouristAttractionCommand, TouristAttraction>();
            CreateMap<CreateCostTypeCommand, CostType>();
            CreateMap<UpdateCostTypeCommand, CostType>();
            CreateMap<CreateTourDetailCommand, TourDetail>();
        }
    }
}
