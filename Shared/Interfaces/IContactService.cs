using Shared.Models;

namespace Shared.Interfaces;

public interface IContactService
{
    bool CreateContact(Contact contact);

    IEnumerable<Contact> GetAllContacts();

    Contact GetOneContact(string email);

    void UpdateContact(Contact contact);

    bool RemoveContact(string email);
}
