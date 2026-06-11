using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.Entity.CustomModels;

namespace OnlineEdu.API.Mapping
{
    public class MonthCourseCountMapping : Profile
    {
        public MonthCourseCountMapping() 
        { 

            CreateMap<ResultMonthlyCourseCountDTO, MonthlyCourseCount>().ReverseMap();

        }
    }
}
