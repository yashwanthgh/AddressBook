using System;
using System.Collections.Generic;

namespace AddressBookProject
{
    public class AddressBook
    {
        private List<Contact> contacts;

        public string Name { get; }

        public AddressBook(string name)
        {
            Name = name;
            contacts = new List<Contact>();
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
            Console.WriteLine("First Name: ");
            string newFirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string newLastName = Console.ReadLine();
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

            if (!string.IsNullOrEmpty(newFirstName))
            {
                contactToEdit.FirstName = newFirstName;
            }
            if (!string.IsNullOrEmpty(newLastName))
            {
                contactToEdit.LastName = newLastName;
            }
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
            return contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
        }

        public bool DeleteContact(string firstName, string lastName)
        {
            Contact contactToDelete = FindContact(firstName, lastName);
            if (contactToDelete == null)
            {
                Console.WriteLine("Contact not found");
                return false;
            }
            contacts.Remove(contactToDelete);
            return true;
        }

        public void ListContacts()
        {
            Console.WriteLine($"** Contacts in {Name} **");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
