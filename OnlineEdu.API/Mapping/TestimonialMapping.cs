using AutoMapper;
using OnlineEdu.DTO.DTOs.TestimonialDTOs;
using OnlineEdu.Entity;
using System.Runtime.CompilerServices;

namespace OnlineEdu.API.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDTO, Testimonial>().ReverseMap();

            CreateMap<UpdateTestimonialDTO, Testimonial>().ReverseMap();
        }


    }
}
