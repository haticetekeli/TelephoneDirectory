using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TelephoneDirectory.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private static List<DirectoryDto> _contacts = new List<DirectoryDto>
        {
            new DirectoryDto { Id = 1, Name = "Ahmet", PhoneNumber = "01234567890" }
        };

        [HttpGet]
        public IActionResult Get() => Ok(_contacts);

        [HttpPost]
        public IActionResult Post(DirectoryDto contact)
        {
            contact.Id = _contacts.Count + 1;
            _contacts.Add(contact);
            return Ok(contact);
        }
    }

    public class DirectoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
