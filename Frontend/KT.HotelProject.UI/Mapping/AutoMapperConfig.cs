using AutoMapper;
using KT.HotelProject.Entity.Concrete;
using KT.HotelProject.UI.Dtos.AboutDto;
using KT.HotelProject.UI.Dtos.BookingDto;
using KT.HotelProject.UI.Dtos.LoginDto;
using KT.HotelProject.UI.Dtos.RegisterDto;
using KT.HotelProject.UI.Dtos.RoomDto;
using KT.HotelProject.UI.Dtos.ServiceDto;
using KT.HotelProject.UI.Dtos.TestimonialDto;

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
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
        }
    }
}
