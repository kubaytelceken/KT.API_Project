using AutoMapper;
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
        }
    }
}
