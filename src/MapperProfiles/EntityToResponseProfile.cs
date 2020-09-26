using AutoMapper;
using src.Contracts.V1.ResponseModels.User;
using src.Entities;

namespace src.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            /** User */
            CreateMap<ApplicationUser, UserResponse>();
        }
    }
}