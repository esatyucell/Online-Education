using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SocialMediaDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(ISocialMediaService socialMediaService, IMapper _mapper) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var values = socialMediaService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
            var value = socialMediaService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
            socialMediaService.TDelete(id);
            return Ok("Sosyal Medya Başarıyla Silindi!");
        }

        [HttpPost]
        public IActionResult Create(CreateSocialMediaDTO createSocialMediaDTO)
        {
            var neValue = _mapper.Map<SocialMedia>(createSocialMediaDTO);
            socialMediaService.TCreate(neValue);
            return Ok("Sosyal Medya Başarıyla Oluşturuldu!");
        }

        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDTO updateSocialMediaDTO) {
            var values = _mapper.Map<SocialMedia>(updateSocialMediaDTO);
            socialMediaService.TUpdate(values);
            return Ok("Sosyal Medya Başarıyla Güncellendi!");
        
        
        }
    }
}
