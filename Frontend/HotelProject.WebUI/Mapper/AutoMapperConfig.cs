using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Login;
using HotelProject.WebUI.Dtos.Register;
using HotelProject.WebUI.Dtos.Service;

namespace HotelProject.WebUI.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<AddServiceDto, Service>().ReverseMap();    
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
           
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
