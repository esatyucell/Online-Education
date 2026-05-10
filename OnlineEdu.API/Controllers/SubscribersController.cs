using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(ISubscriberService _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() { 
            var values = _subscriberService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
            _subscriberService.TDelete(id);
            return Ok("Abone Başarıyla Silindi!");
        }
        [HttpPost]
        public IActionResult Create(CreateSubscriberDTO _createSubscriberDTO)
        {
            var newValue = _mapper.Map<Subscriber>(_createSubscriberDTO);
            _subscriberService.TCreate(newValue);
            return Ok("Abone Başarıyla Oluşturuldu!");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubscriberDTO _updateSubscriberDTO) {
            var values = _mapper.Map<Subscriber>(_updateSubscriberDTO);
            _subscriberService.TUpdate(values);
            return Ok("Abone Başarıyla Güncellendi !");
        
        }
    }
}
