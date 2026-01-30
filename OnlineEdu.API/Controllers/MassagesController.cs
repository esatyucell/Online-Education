using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDTOs;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;
namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
        var values = _messageService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
            _messageService.TDelete(id);
            return Ok("Mesaj Başarıyla Silindi!");
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDTO createMessageDTO)
        {
            var newValue = _mapper.Map<Message>(createMessageDTO);
            _messageService.TCreate(newValue);
            return Ok("Mesaj Başarıyla Kaydedildi !");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDTO updateMessageDTO) { 
        var value = _mapper.Map<Message>(updateMessageDTO);
        _messageService.TUpdate(value);
        return Ok(value);
        }
    }
}
