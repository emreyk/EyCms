using AutoMapper;
using EyCms.CORE.DTOs;
using EyCms.CORE.Models;

namespace EyCms.SERVICE.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<User, LoginDto>().ReverseMap();
        }
    }
}
