using Business.Models;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IContactService
    {
        bool CreateContact(Contact contact);
        IEnumerable<Contact> GetAllContacts();
        bool SaveListToFile();
        bool GetListFromFile();
    }
}
