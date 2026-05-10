using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping() {
            CreateMap<CreateBlogCategoryDTO, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDTO, BlogCategory>().ReverseMap();

        }
    }
}
