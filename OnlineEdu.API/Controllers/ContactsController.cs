using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.ContactSTOs;
using OnlineEdu.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IContactService _contactService, IMapper _mapper) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]

        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id) { 
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("Contact Silindi!");
        }

        [HttpPost]

        public IActionResult Create(CreateContactDTO _createContactDTO)
        {
            var newValue = _mapper.Map<Contact>(_createContactDTO);
            _contactService.TCreate(newValue);
            return Ok("Contact Başarıyla Oluşturuldu!");
        }

        [HttpPut]

        public IActionResult Update(UpdateContactDTO _updateContactDTO)
        {
            var values = _mapper.Map<Contact>(_updateContactDTO);
            _contactService.TUpdate(values);
            return Ok("Contact Başarıyla Güncellendi!");
        }
    }
}
