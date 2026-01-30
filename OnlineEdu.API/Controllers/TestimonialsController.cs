using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.DTO.DTOs.TestimonialDTO;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _testimonialService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Referans Başarıyla Silindi!");
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialDTO createTestimonialDTO)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDTO);
            _testimonialService.TCreate(newValue);
            return Ok("Referans Başarıyla Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateTestimonialDTO updateTestimonialDTO)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDTO);
            _testimonialService.TUpdate(value);
            return Ok("Referans Başarıyla Güncellendi!");
        }
    }
}
