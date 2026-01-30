using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _courseCategoryService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
        var value = _courseCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Kurs Kategori Başarıyla Silindi!");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseCategory createCourseCategory)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategory);
            _courseCategoryService.TCreate(newValue);
            return Ok("Kurs Kategori Başarıyla Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseCategory updateCourseCategory)
        {
            var value = _mapper.Map<CourseCategory>(updateCourseCategory);
            _courseCategoryService.TUpdate(value);
            return Ok("Kurs Kategori Başarıyla Güncellendi!");
        }
    }
}
