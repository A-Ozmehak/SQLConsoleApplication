using Shared.Interfaces;
using Shared.Models;
using Shared.Services;

namespace ConsoleApp.Services;

internal class MenuService(IContactService contactService)
{
    public readonly IContactService _contactService = contactService;

  
    public void Menu()
    {
        

        Console.WriteLine("----- AddressBook -----");

        while(true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1.Add a new contact");
            Console.WriteLine("2.Get all contacts");
            Console.WriteLine("3.Get one contact");
            Console.WriteLine("4.Delete a contact");
            Console.WriteLine("5.Close the application");
            Console.WriteLine();
            Console.WriteLine("Choose an option");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddContactOptions();
                    break;
                case "2":
                    GetAllContactsOption();
                    break;
                case "3":
                    GetOneContactOption();
                    break;
                case "4":
                    DeleteContactOption();
                    break;
                case "5":
                    CloseApplicationOption();
                    break;
            }
        }
    }

    public void AddContactOptions()
    {
        var contact = new Contact();

        Console.WriteLine("Add Contact");
        Console.WriteLine("-------------");

        Console.Write("FirstName: ");
        contact.FirstName = Console.ReadLine()!;

        Console.Write("Lastname: ");
        contact.LastName = Console.ReadLine()!;

        Console.Write("Email: ");
        contact.Email = Console.ReadLine()!;

        Console.Write("PhoneNumber: ");
        contact.PhoneNumber = Console.ReadLine()!;

        Console.Write("Address: ");
        contact.Address = Console.ReadLine()!;

        Console.Write("PostalCode: ");
        contact.PostalCode = Console.ReadLine()!;

        Console.Write("City: ");
        contact.City = Console.ReadLine()!;
    }

    public void GetAllContactsOption()
    {
        
    }

    public void GetOneContactOption()
    {

    }

    public void DeleteContactOption()
    { }

    public void CloseApplicationOption()
    { }
}
