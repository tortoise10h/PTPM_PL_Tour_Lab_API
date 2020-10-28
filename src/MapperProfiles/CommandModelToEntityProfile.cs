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
using src.CQRS.Group.Commands.CreateGroup;
using src.CQRS.Group.Commands.UpdateGroup;
using src.CQRS.GroupDetail.Commands.CreateGroupDetail;
using src.CQRS.GroupDetail.Commands.UpdateGroupDetail;
using src.CQRS.GroupRole.Commands.UpdateGroupRole;
using src.CQRS.GroupRole.Commands.CreateGroupRole;
using src.CQRS.GroupCost.Commands.CreateGroupCost;
using src.CQRS.GroupCost.Commands.UpdateGroupCost;
using src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole;

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

            CreateMap<CreateGroupCommand, Group>();
            CreateMap<UpdateGroupCommand, Group>();

            CreateMap<UpdateTourPriceCommand, TourPrice>();

            CreateMap<CreateGroupDetailCommand, GroupDetail>();
            CreateMap<UpdateGroupDetailCommand, GroupDetail>();

            CreateMap<CreateGroupRoleCommand, GroupRole>();
            CreateMap<UpdateGroupRoleCommand, GroupRole>();

            CreateMap<CreateGroupCostCommand, GroupCost>();
            CreateMap<UpdateGroupCostCommand, GroupCost>();

            CreateMap<CreateStaffGroupRoleCommand, StaffGroupRole>();
        }
    }
}
