using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactSTOs;
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
