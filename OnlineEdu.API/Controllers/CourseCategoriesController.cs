using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(ICourseCategoryService _courseCategoryService, IMapper _mapper) : ControllerBase
    {

        [HttpGet]

        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
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

        public IActionResult Create(CreateCourseCategoryDTO createCourseCategoryDTO)
        {
            var newValues = _mapper.Map<CourseCategory>(createCourseCategoryDTO);
            _courseCategoryService.TCreate(newValues);
            return Ok("Kurs Kategorisi Oluşturuldu!");
        }


        [HttpPut]

        public IActionResult Update(UpdateCourseCategoryDTO updateCourseCategoryDTO)
        {
            var values = _mapper.Map<CourseCategory>(updateCourseCategoryDTO);
            _courseCategoryService.TUpdate(values);
            return Ok("Kurs Kategorisi Başarıyla Güncellendi !");
        }
    }
}
