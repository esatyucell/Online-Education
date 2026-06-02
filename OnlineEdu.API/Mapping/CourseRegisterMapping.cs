using OnlineEdu.DTO.DTOs.CourseRegisterDTOs;
using OnlineEdu.Entity;
using AutoMapper;

namespace OnlineEdu.API.Mapping
{
    public class CourseRegisterMapping : Profile
    {
        public CourseRegisterMapping() {
            CreateMap<CourseRegister, ResultCourseRegisterDTO>().ReverseMap();
            CreateMap<CourseRegister, CreateCourseRegisterDTO>().ReverseMap();
            CreateMap<CourseRegister, UpdateCourseRegisterDTO>().ReverseMap();
        }
    }
}
