using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class AddressBook
    {
        private HashSet<Contact> contacts;

        public AddressBook()
        {
            contacts = new HashSet<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public bool EditContact(string firstName, string lastName)
        {
            Contact contactToEdit = FindContact(firstName, lastName);
            if (contactToEdit == null)
            {
                Console.WriteLine("Contact not found.");
                return false;
            }

            Console.WriteLine("Enter new details (leave blank to keep existing value):");
            Console.Write("Address: ");
            string newAddress = Console.ReadLine();
            Console.Write("City: ");
            string newCity = Console.ReadLine();
            Console.Write("State: ");
            string newState = Console.ReadLine();
            Console.Write("Zip: ");
            string newZip = Console.ReadLine();
            Console.Write("Phone Number: ");
            string newPhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string newEmail = Console.ReadLine();

            if (!string.IsNullOrEmpty(newAddress))
            {
                contactToEdit.Address = newAddress;
            }
            if (!string.IsNullOrEmpty(newCity))
            {
                contactToEdit.City = newCity;
            }
            if (!string.IsNullOrEmpty(newState))
            {
                contactToEdit.State = newState;
            }
            if (!string.IsNullOrEmpty(newZip))
            {
                contactToEdit.Zip = newZip;
            }
            if (!string.IsNullOrEmpty(newPhoneNumber))
            {
                contactToEdit.PhoneNumber = newPhoneNumber;
            }
            if (!string.IsNullOrEmpty(newEmail))
            {
                contactToEdit.Email = newEmail;
            }

            Console.WriteLine("Contact edited successfully!");
            return true;
        }

        private Contact FindContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }

        public HashSet<Contact> GetContacts()
        {
            return contacts;
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found in the address book.");
                return;
            }

            Console.WriteLine("** Contacts List **");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}, State: {contact.State} Zip: {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine("--------------------");
            }
        }
    }

}
