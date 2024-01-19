using Shared.Entities;
using Shared.Interfaces;
using Shared.Models;
using Shared.Repositories;

namespace Shared.Services;

public class ContactService(ContactRepository contactRepository, AddressRepository addressRepository, PhoneNumberRepository phoneNumberRepository) : IContactService
{
    private readonly ContactRepository _contactRepository = contactRepository;
    private readonly AddressRepository _addressRepository = addressRepository;
    private  readonly PhoneNumberRepository _phoneNumberRepository = phoneNumberRepository;

    public bool CreateContact(Contact contact)
    {
        var contactEntity = new ContactEntity
        {
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Email = contact.Email,
            AddressId = _addressRepository.Create(new AddressEntity
            {
                Address = contact.Address,
                PostalCode = contact.PostalCode,
                City = contact.City
            }),
            //PhoneNumberId = _phoneNumberRepository.Create(new PhoneNumberEntity { PhoneNumber = contact.PhoneNumber }),

        };

        //int result = _contactRepository.Create(contactEntity);
        //return result > 0;
        return true;
    }

    public IEnumerable<Contact> GetAllContacts()
    {
        throw new NotImplementedException();
    }

    public Contact GetOneContact(string email)
    {
        throw new NotImplementedException();
    }

    public bool RemoveContact(string email)
    {
        throw new NotImplementedException();
    }

    public void UpdateContact(Contact contact)
    {
        throw new NotImplementedException();
    }
}
