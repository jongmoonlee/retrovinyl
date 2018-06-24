using AutoMapper;
using RetroVynyl.API.Dtos;
using RetroVynyl.API.Models;

namespace RetroVynyl.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
        }
    }
}