using AutoMapper;
using Vue.Domain.Models;
using Vue.Entity.Entities;

namespace Vue.WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
        }
    }
}
