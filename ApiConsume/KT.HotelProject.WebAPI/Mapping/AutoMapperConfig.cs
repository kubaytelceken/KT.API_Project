using AutoMapper;
using KT.HotelProject.DTO.Dtos.AboutDto;
using KT.HotelProject.DTO.Dtos.RoomDto;
using KT.HotelProject.Entity.Concrete;

namespace KT.HotelProject.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
            CreateMap<AboutAddDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();
        }
    }
}
