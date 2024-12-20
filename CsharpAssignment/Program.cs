using Business.Services;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Business.Dialogs;

class Program
{
    static void Main(string[] args)
    {
        var fileService = new FileService("Data", "contacts.json");
        var contactService = new ContactService(fileService);
        var menu = new MenuDialogs(contactService);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. View all contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option: ");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    menu.AddNewContact();
                    break;
                case "2":
                    menu.ViewAllContacts();
                    Console.ReadKey();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Wrong option. Please try again.");
                    break;
            }
        }
    }
}
