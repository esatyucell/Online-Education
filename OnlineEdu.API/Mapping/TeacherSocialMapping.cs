using AutoMapper;
using OnlineEdu.DTO.DTOs.TeacherSocialDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class TeacherSocialMapping : Profile
    {
        public TeacherSocialMapping()
        {
            CreateMap<TeacherSocial, ResultTeacherSocialDTO>().ReverseMap();
            CreateMap<TeacherSocial, CreateTeacherSocialDTO>().ReverseMap();
            CreateMap<TeacherSocial, UpdateTeacherSocialDTO>().ReverseMap();
        }
    }
}