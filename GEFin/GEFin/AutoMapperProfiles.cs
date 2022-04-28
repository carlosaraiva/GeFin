using AutoMapper;
using GEFin.Api.Dto;
using GEFin.Model;

namespace GEFin.Api
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForList>();
            CreateMap<User, UserForDetailed>();
            CreateMap<UserForRegister, User>();
            CreateMap<UserForUpdate, User>();
        }
    }
}