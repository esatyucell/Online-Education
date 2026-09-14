using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping() {
            CreateMap<CreateContactDTO, Contact>().ReverseMap();
            CreateMap<UpdateContactDTO, Contact>().ReverseMap();
        }
    }
}
