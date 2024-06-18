using ContactManagement.Models;

namespace ContactManagement.ContactService
{
	public interface IContactService
	{
		IEnumerable<Contact> GetContacts();
		Contact GetContactById(int id);
		Contact CreateContact(Contact contact);
		Contact UpdateContact(int id, Contact contact);
		bool DeleteContact(int id);
	}
}
