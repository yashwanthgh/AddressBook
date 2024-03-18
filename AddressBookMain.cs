using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book!");
            Console.WriteLine("To add a new contact Press 1");
            Console.WriteLine("To edit contact Press 2");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ContactController addContact = new ContactController();
                    addContact.AddNewContact();
                    break;
                case 2:
                    ContactController editContact = new ContactController();
                    editContact.EditContact();
                    break;
            }
        }
    }
}
