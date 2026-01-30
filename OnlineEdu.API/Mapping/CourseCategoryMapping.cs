using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;


namespace OnlineEdu.API.Mapping
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping() {
            CreateMap<CreateCourseCategory, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategory, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDTO, CourseCategory>().ReverseMap();
        }
    }
}
