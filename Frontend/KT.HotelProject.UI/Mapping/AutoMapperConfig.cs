using AutoMapper;
using KT.HotelProject.Entity.Concrete;
using KT.HotelProject.UI.Dtos.LoginDto;
using KT.HotelProject.UI.Dtos.RegisterDto;
using KT.HotelProject.UI.Dtos.ServiceDto;

namespace KT.HotelProject.UI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
