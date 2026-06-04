using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IBlogService _blogService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            var values = _blogService.TGetBlogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDTO>>(values);
            return Ok(blogs);   
        }

        [HttpGet("GetLast4Blogs")]

        public IActionResult GetLast4Blogs()
        {
            var values = _blogService.TGetLast4BlogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDTO>>(values);
            return Ok(blogs);
        }

        [HttpGet("GetBlogsByCategoryId/{id}")]

        public IActionResult GetBlogsByCategoryId(int id)
        {
            var blogs = _blogService.TGetBlogsByCategoryId(id);
            return Ok(blogs);

        }

        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var blogCount = _blogService.TCount();
            return Ok(blogCount);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Başarıyla Silindi!");
        }

        [HttpPost]

        public IActionResult Create(CreateBlogDTO createBlogDTO)
        {
            var newValue = _mapper.Map<Blog>(createBlogDTO);
            _blogService.TCreate(newValue);
            return Ok("Blog Başarıyla Oluşturuldu!");

        }


        [HttpPut]

        public IActionResult Update(UpdateBlogDTO updateBlogDTO)
        {
            var values = _mapper.Map<Blog>(updateBlogDTO);
            _blogService.TUpdate(values);
            return Ok("Blog Başarıyla Güncellendi !");


        }













        }
}
