using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IMessageService _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { 
            _messageService.TDelete(id);
            return Ok("Mesaj Başarıyla Silindi !");
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDTO createMessageDTO) {
            var newValues = _mapper.Map<Message>(createMessageDTO);
            _messageService.TCreate(newValues);
            return Ok("Mesaj Başarıyla Oluşturuldu !");
        
        }
        [HttpPut]

        public IActionResult Update(UpdateMessageDTO updateMessageDTO) {
            var values = _mapper.Map<Message>(updateMessageDTO);
            _messageService.TUpdate(values);
            return Ok("Mesaj Başarıyla Güncellendi!");
        
        }
    }
}
