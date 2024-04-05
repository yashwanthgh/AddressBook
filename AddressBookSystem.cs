using System;
using System.Collections.Generic;

namespace AddressBookProject
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("An address book with that name already exists.");
                return;
            }

            addressBooks.Add(name, new AddressBook(name));
            Console.WriteLine("Address book '{0}' created successfully!", name);
        }

        public AddressBook GetSelectedAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No address books found. Please create one first.");
                return null;
            }

            Console.WriteLine("Select an address book:");
            int index = 1;
            foreach (string bookName in addressBooks.Keys)
            {
                Console.WriteLine($"{index}. {bookName}");
                index++;
            }

            Console.Write("Enter your choice (number): ");
            string choice = Console.ReadLine();
            int choiceInt;

            while (!int.TryParse(choice, out choiceInt) || choiceInt < 1 || choiceInt > addressBooks.Count)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and {0}.", addressBooks.Count);
                choice = Console.ReadLine();
            }

            string selectedAddressBookName = addressBooks.Keys.ElementAt(choiceInt - 1);
            return addressBooks[selectedAddressBookName];
        }
    }
}
