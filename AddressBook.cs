using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class AddressBook
    {
        private readonly HashSet<Contact> contacts;
        public AddressBook()
        {
            contacts = [];
        }
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

    }
}
