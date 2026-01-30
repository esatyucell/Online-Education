using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity.Entities;
namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            var value = _subscriberService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id) { 
        _subscriberService.TDelete(id);
        return Ok("Abone Başarıyla Silindi!");
        }

        [HttpPost]
        public IActionResult Create(CreateSubscriberDTO createSubscriberDTO)
        {
            var newValue = _mapper.Map<Subscriber>(createSubscriberDTO);
            _subscriberService.TCreate(newValue);
            return Ok("Abone Başarıyla Oluşturuldu1");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubscriberDTO updateSubscriberDTO) { 
        var value = _mapper.Map<Subscriber>(updateSubscriberDTO);
        _subscriberService.TUpdate(value);
            return Ok("Abone Başarıyla Güncellendi !");
        }
    }
}
