using System.Collections.Generic;
using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ContactService : IContactService
    {
        private readonly IFileService _fileService;
        private List<Contact> _contacts = new();

        public ContactService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public bool CreateContact(Contact contact)
        {
            contact.Id = Guid.NewGuid().ToString();
            _contacts.Add(contact);
            return SaveListToFile();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            GetListFromFile();
            return _contacts;
        }

        public bool SaveListToFile()
        {
            var json = JsonSerializer.Serialize(_contacts);
            return _fileService.SaveContentToFile(json);
        }

        public bool GetListFromFile()
        {
            var content = _fileService.GetContentFromFile();
            if (content != null)
                _contacts = JsonSerializer.Deserialize<List<Contact>>(content)!;

            return content != null;
        }
    }
}
