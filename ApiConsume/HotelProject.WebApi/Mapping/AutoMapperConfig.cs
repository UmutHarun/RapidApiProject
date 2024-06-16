using AutoMapper;
using HotelProject.DtoLayer.Dtos.Staff;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<Staff, AddStaffDto>();
            CreateMap<AddStaffDto, Staff>();

            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
        }
    }
}
