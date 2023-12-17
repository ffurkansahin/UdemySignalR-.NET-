using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;
using SignalR.EntityLayer;

namespace SignalR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact
            {
                Description = createContactDto.Description,
                Location = createContactDto.Location,
                MailAdres = createContactDto.MailAdres,
                PhoneNumber = createContactDto.PhoneNumber
            });
            return Ok("Contact added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Contact deleted");
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact 
            {
                ID = updateContactDto.ID,
                Location = updateContactDto.Location,
                MailAdres= updateContactDto.MailAdres,
                PhoneNumber = updateContactDto.PhoneNumber,
                Description = updateContactDto.Description
            });
            return Ok("Category updated");
        }
        [HttpGet("{id}")]
        public IActionResult GetContactById(int id) 
        {
            return Ok(_contactService.TGetById(id));
        }
    }
}
