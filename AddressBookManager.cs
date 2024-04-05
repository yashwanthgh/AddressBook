using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class AddressBookManager
    {
        private AddressBook addressBook;

        public AddressBookManager()
        {
            addressBook = new AddressBook();
        }

        public void AddContact()
        {
            Console.WriteLine("Enter Contact Details:");
            Console.Write("First Name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string? lastName = Console.ReadLine();
            Console.Write("Address: ");
            string? address = Console.ReadLine();
            Console.Write("City: ");
            string? city = Console.ReadLine();
            Console.Write("State: ");
            string? state = Console.ReadLine();
            Console.Write("Zip: ");
            string? zip = Console.ReadLine();
            Console.Write("Phone Number: ");
            string? phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string? email = Console.ReadLine();

            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.AddContact(newContact);
            Console.WriteLine("Contact added successfully!");
        }
    }
}
