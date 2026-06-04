using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBlogDTO, Blog>().ReverseMap();
            CreateMap<UpdateBlogDTO, Blog>().ReverseMap();
            CreateMap<Blog, ResultBlogDTO>().ReverseMap();
        }
    }
}
