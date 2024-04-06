using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookProject
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;
        private Dictionary<string, List<Contact>> personsByCity;
        private Dictionary<string, List<Contact>> personsByState;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            personsByCity = new Dictionary<string, List<Contact>>();
            personsByState = new Dictionary<string, List<Contact>>();
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

        public List<Contact> SearchPersonInCityOrState(string searchQuery)
        {
            List<Contact> searchResults = new List<Contact>();
            foreach (var addressBook in addressBooks.Values)
            {
                searchResults.AddRange(addressBook.FindContactsInCityOrState(searchQuery));
            }
            return searchResults;
        }

        public Dictionary<string, List<Contact>> ViewPersonsByCity()
        {
            return personsByCity;
        }

        public Dictionary<string, List<Contact>> ViewPersonsByState()
        {
            return personsByState;
        }

        public void AddPersonToCityDictionary(Contact contact)
        {
            if (!personsByCity.ContainsKey(contact.City))
            {
                personsByCity[contact.City] = new List<Contact>();
            }
            personsByCity[contact.City].Add(contact);
        }

        public void AddPersonToStateDictionary(Contact contact)
        {
            if (!personsByState.ContainsKey(contact.State))
            {
                personsByState[contact.State] = new List<Contact>();
            }
            personsByState[contact.State].Add(contact);
        }

        public Dictionary<string, int> GetCountByCity()
        {
            Dictionary<string, int> countByCity = new Dictionary<string, int>();
            foreach (var kvp in personsByCity)
            {
                countByCity[kvp.Key] = kvp.Value.Count;
            }
            return countByCity;
        }

        public Dictionary<string, int> GetCountByState()
        {
            Dictionary<string, int> countByState = new Dictionary<string, int>();
            foreach (var kvp in personsByState)
            {
                countByState[kvp.Key] = kvp.Value.Count;
            }
            return countByState;
        }
    }
}
