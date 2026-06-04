using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseRegisterDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    public class CourseRegistersController(ICourseRegisterService _courseRegisterService, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public IActionResult RegisterToCourse(CreateCourseRegisterDTO model)
        {
            var newCourseRegister = _mapper.Map<CourseRegister>(model);
            _courseRegisterService.TCreate(newCourseRegister);
            return Ok("Kursa Kayıt Başarılı");
        }
        [HttpPut]

        public IActionResult UpdateCourseRegister(UpdateCourseRegisterDTO model)
        {
            var updateModel = _mapper.Map<CourseRegister>(model);
            _courseRegisterService.TUpdate(updateModel);
            return Ok("Kurs Kaydı Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseRegisterService.TGetById(id);
            var mappedValue = _mapper.Map<ResultCourseRegisterDTO>(value);
            return Ok(mappedValue);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourseRegister(int id) 
        {
            _courseRegisterService.TDelete(id);
            return Ok("Kurs Kaydı Silindi");
        }



    }
}
