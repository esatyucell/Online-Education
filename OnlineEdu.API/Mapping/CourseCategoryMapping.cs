using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping() {
            CreateMap<CreateCourseCategoryDTO, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDTO, CourseCategory>().ReverseMap();
        }
    }
}
