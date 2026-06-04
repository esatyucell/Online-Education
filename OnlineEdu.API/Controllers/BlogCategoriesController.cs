using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IBlogCategoryService _blogCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogCategoryService.TGetCategoriesWithBlogs();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id) 
        {
            var value = _blogCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id) 
        {
            _blogCategoryService.TDelete(id);
            return Ok("Blog Kategorisi Silindi !");
        }

        [HttpPost]

        public IActionResult Create(CreateBlogCategoryDTO _createBlogCategoryDTO)
        {
            var newValue = _mapper.Map<BlogCategory>(_createBlogCategoryDTO);
            _blogCategoryService.TCreate(newValue);
            return Ok("Blog Kategorisi Başarıyla Oluşturuldu!");
        }

        [HttpPut]

        public IActionResult Update(UpdateBlogCategoryDTO _updateBlogCategoryDTO)
        {
            var values = _mapper.Map<BlogCategory>(_updateBlogCategoryDTO);
            _blogCategoryService.TUpdate(values);
            return Ok("Blog Kategorisi Başarıyla Güncellendi! ");

        }
    }
}
