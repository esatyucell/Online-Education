using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannerService _bannerService, IMapper _mapper) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
        
            var values = _bannerService.TGetById(id);
            return Ok(values);
        
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id) { 
        
            _bannerService.TDelete(id);
            return Ok("Banner Başarıyla Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDTO createBannerDTO)
        {
            var newValue = _mapper.Map<Banner>(createBannerDTO);
            _bannerService.TCreate(newValue);
            return Ok("Banner Başarıyla Oluşturuldu!");
        }

        [HttpPut]

        public IActionResult Update(UpdateBannerDTO updateBannerDTO) 
        {
            var values = _mapper.Map<Banner>(updateBannerDTO);
            _bannerService.TUpdate(values);
            return Ok("Banner Başarıyla Güncellendi!");
        
        }



    }
}
