using AutoMapper;
using src.Contracts.V1.ResponseModels.CostType;
using src.Contracts.V1.ResponseModels.Group;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Contracts.V1.ResponseModels.TourDetail;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Contracts.V1.ResponseModels.User;
using src.Entities;

namespace src.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();
            CreateMap<TourCategory, TourCategoryResponse>();
            CreateMap<Tour, TourResponse>();
            CreateMap<TouristAttraction, TouristAttractionResponse>();
            CreateMap<TourDetail, TourDetailResponse>();
            CreateMap<CostType, CostTypeResponse>();
            CreateMap<TourPrice, TourPriceResponse>();
            CreateMap<Group, GroupResponse>();
            CreateMap<GroupDetail, GroupDetailResponse>();
            CreateMap<GroupRole, GroupRoleResponse>();
        }
    }
}