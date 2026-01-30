using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> _blogCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _blogCategoryService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.TDelete(id);
            return Ok("Blog Kategori Başarıyla Silindi !");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDTO createBlogCategoryDTO) { 
        var newValue = _mapper.Map<BlogCategory>(createBlogCategoryDTO);
            _blogCategoryService.TCreate(newValue);
            return Ok("Blog Kategori Başarıyla Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateBlogCategoryDTO updateBlogCategoryDTO)
        {
            var value = _mapper.Map<BlogCategory>(updateBlogCategoryDTO);
            _blogCategoryService.TUpdate(value);
            return Ok("Blog Kategori Başarıyla Güncellendi");
        }
    }
}
