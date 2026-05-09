using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.Entity;
using AutoMapper;

namespace OnlineEdu.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();
        }
    }
}
