using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.TestimonialDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(ITestimonialService _testimonialService, IMapper _mapper) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
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
            return Ok("Hakkımızda Alanı Silindi!");
        }

        [HttpPost]

        public IActionResult Create(CreateTestimonialDTO createTestimonialDTO)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDTO);
            _testimonialService.TCreate(newValue);
            return Ok("Yeni Hakkımızda Alanı Oluşturuldu!");
        }

        [HttpPut]

        public IActionResult Update(UpdateTestimonialDTO updateTestimonialDTO)
        {
            var values = _mapper.Map<Testimonial>(updateTestimonialDTO);
            _testimonialService.TUpdate(values);
            return Ok("Hakkımızda Alanı Güncellendi");

        }

        [AllowAnonymous]
        [HttpGet("GetTestimonialCount")]
        public IActionResult GetTestimonialCount()
        {
            var courseCount = _testimonialService.TCount();
            return Ok(courseCount);
        }
    }
}
