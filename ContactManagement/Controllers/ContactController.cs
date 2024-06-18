using ContactManagement.ContactService;
using ContactManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
			private readonly IContactService _contactService;

			public ContactController(IContactService contactService)
			{
				_contactService = contactService;
			}

			[HttpGet]
			public IActionResult GetContacts()
			{
				return Ok(_contactService.GetContacts());
			}

			[HttpGet("{id}")]
			public IActionResult GetContact(int id)
			{
				var contact = _contactService.GetContactById(id);
				if (contact == null) return NotFound();
				return Ok(contact);
			}

			[HttpPost]
			public IActionResult CreateContact(Contact contact)
			{
				if (!ModelState.IsValid) return BadRequest(ModelState);
				var createdContact = _contactService.CreateContact(contact);
				return CreatedAtAction(nameof(GetContact), new { id = createdContact.Id }, createdContact);
			}

			[HttpPut("{id}")]
			public IActionResult UpdateContact(int id, Contact contact)
			{
				if (!ModelState.IsValid) return BadRequest(ModelState);
				var updatedContact = _contactService.UpdateContact(id, contact);
				if (updatedContact == null) return NotFound();
				return Ok(updatedContact);
			}

			[HttpDelete("{id}")]
			public IActionResult DeleteContact(int id)
			{
				var deleted = _contactService.DeleteContact(id);
				if (!deleted) return NotFound();
				return NoContent();
			}
		}
	}

