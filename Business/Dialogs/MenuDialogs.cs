using System;
using Business.Models;
using Business.Interfaces;

namespace Business.Dialogs
{
    public class MenuDialogs
    {
        private readonly IContactService _contactService;

        public MenuDialogs(IContactService contactService)
        {
            _contactService = contactService;
        }

        public void AddNewContact()
        {
            var contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine()!;

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine()!;

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine()!;

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine()!;

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine()!;

            Console.Write("Enter Postal Code: ");
            contact.PostalCode = Console.ReadLine()!;

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine()!;

            if (_contactService.CreateContact(contact))
                Console.WriteLine("Contact added!");
            else
                Console.WriteLine("Failed to add contact, please try again.");
        }

        public void ViewAllContacts()
        {
            var contacts = _contactService.GetAllContacts();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"ID: {contact.Id}, Name: {contact.FirstName} {contact.LastName}, Email: {contact.Email}, Phone number: {contact.PhoneNumber}, Address: {contact.Address}, Postal code: {contact.PostalCode}, City: {contact.City}");
            }
        }
    }
}
