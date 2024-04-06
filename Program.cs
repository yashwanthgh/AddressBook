using System;

namespace AddressBookProject
{
    public class Program
    {
        static AddressBookSystem addressBookSystem = new AddressBookSystem();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n** Address Book System Menu **");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Search Person by City or State");
                Console.WriteLine("4. Exit System");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                int choiceInt;

                while (!int.TryParse(choice, out choiceInt) || choiceInt < 1 || choiceInt > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    choice = Console.ReadLine();
                }

                switch (choiceInt)
                {
                    case 1:
                        Console.Write("Enter a name for the address book: ");
                        string addressBookName = Console.ReadLine();
                        addressBookSystem.AddAddressBook(addressBookName);
                        break;
                    case 2:
                        AddressBook selectedAddressBook = addressBookSystem.GetSelectedAddressBook();
                        if (selectedAddressBook != null)
                        {
                            AddressBookManager addressBookManager = new AddressBookManager(selectedAddressBook);
                            ManageContactsInAddressBook(addressBookManager);
                        }
                        break;
                    case 3:
                        SearchPersonByCityOrState();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Address Book System.");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static void ManageContactsInAddressBook(AddressBookManager addressBookManager)
        {
            while (true)
            {
                Console.WriteLine("** Address Book **");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBookManager.AddContact();
                        break;
                    case "2":
                        addressBookManager.EditContact();
                        break;
                    case "3":
                        addressBookManager.DeleteContact();
                        break;
                    case "4":
                        Console.WriteLine("Exiting Address Book");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void SearchPersonByCityOrState()
        {
            Console.WriteLine("Enter city or state to search: ");
            string searchQuery = Console.ReadLine();
            List<Contact> searchResults = addressBookSystem.SearchPersonInCityOrState(searchQuery);
            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results for '{searchQuery}':");
                foreach (var contact in searchResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"No matching contacts found for '{searchQuery}'.");
            }
        }
    }
}
