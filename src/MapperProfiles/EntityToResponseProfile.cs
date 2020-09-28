using AutoMapper;
using src.Contracts.V1.ResponseModels.TourCategory;
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
        }
    }
}