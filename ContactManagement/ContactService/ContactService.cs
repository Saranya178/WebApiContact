using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ContactManagement.Models;


namespace ContactManagement.ContactService
{
	public class ContactService : IContactService
	{
		private readonly string _filePath;
		private List<Contact> _contacts;

		public ContactService()
		{
			_filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "contacts.json");
			_contacts = LoadContacts();
		}

		private List<Contact> LoadContacts()
		{
			if (!File.Exists(_filePath))
			{
				File.WriteAllText(_filePath, "[]");
			}
			var jsonData = File.ReadAllText(_filePath);
			return JsonConvert.DeserializeObject<List<Contact>>(jsonData) ?? new List<Contact>();
		}

		private void SaveContacts()
		{
			var jsonData = JsonConvert.SerializeObject(_contacts);
			File.WriteAllText(_filePath, jsonData);
		}

		public IEnumerable<Contact> GetContacts() => _contacts;

		public Contact GetContactById(int id) => _contacts.FirstOrDefault(c => c.Id == id);

		public Contact CreateContact(Contact contact)
		{
			contact.Id = _contacts.Any() ? _contacts.Max(c => c.Id) + 1 : 1;
			_contacts.Add(contact);
			SaveContacts();
			return contact;
		}

		public Contact UpdateContact(int id, Contact contact)
		{
			var existingContact = GetContactById(id);
			if (existingContact == null) return null;

			existingContact.FirstName = contact.FirstName;
			existingContact.LastName = contact.LastName;
			existingContact.Email = contact.Email;
			SaveContacts();
			return existingContact;
		}

		public bool DeleteContact(int id)
		{
			var contact = GetContactById(id);
			if (contact == null) return false;

			_contacts.Remove(contact);
			SaveContacts();
			return true;
		}
	}
}
