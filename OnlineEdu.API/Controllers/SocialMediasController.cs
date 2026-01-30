using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.SocialMediaDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> _socialMediaService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _socialMediaService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Sosyal Medya Başarıyla Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateSocialMediaDTO createSocialMediaDTO)
        {
            var newValue = _mapper.Map<SocialMedia>(createSocialMediaDTO);
            _socialMediaService.TCreate(newValue);
            return Ok("Sosyal Medya Başarıyla Oluşturuldu!");
        }
        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDTO updateSocialMediaDTO)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialMediaDTO);
            _socialMediaService.TUpdate(value);
            return Ok("Sosyal Medya Başarıyla Güncellendi !");
        }
    }
}
