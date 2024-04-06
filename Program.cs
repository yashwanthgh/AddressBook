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
                Console.WriteLine("4. View Persons by City");
                Console.WriteLine("5. View Persons by State");
                Console.WriteLine("6. Get Count by City");
                Console.WriteLine("7. Get Count by State");
                Console.WriteLine("8. Exit System");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                int choiceInt;

                while (!int.TryParse(choice, out choiceInt) || choiceInt < 1 || choiceInt > 8)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
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
                            AddressBookManager addressBookManager = new AddressBookManager(selectedAddressBook, addressBookSystem);
                            ManageContactsInAddressBook(addressBookManager);
                        }
                        break;
                    case 3:
                        SearchPersonByCityOrState();
                        break;
                    case 4:
                        ViewPersonsByCity();
                        break;
                    case 5:
                        ViewPersonsByState();
                        break;
                    case 6:
                        GetCountByCity();
                        break;
                    case 7:
                        GetCountByState();
                        break;
                    case 8:
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

        private static void ViewPersonsByCity()
        {
            Dictionary<string, List<Contact>> personsByCity = addressBookSystem.ViewPersonsByCity();
            if (personsByCity.Count > 0)
            {
                Console.WriteLine("Persons by City:");
                foreach (var kvp in personsByCity)
                {
                    Console.WriteLine($"City: {kvp.Key}");
                    foreach (var contact in kvp.Value)
                    {
                        Console.WriteLine(contact);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }

        private static void ViewPersonsByState()
        {
            Dictionary<string, List<Contact>> personsByState = addressBookSystem.ViewPersonsByState();
            if (personsByState.Count > 0)
            {
                Console.WriteLine("Persons by State:");
                foreach (var kvp in personsByState)
                {
                    Console.WriteLine($"State: {kvp.Key}");
                    foreach (var contact in kvp.Value)
                    {
                        Console.WriteLine(contact);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }
        private static void GetCountByCity()
        {
            Dictionary<string, int> countByCity = addressBookSystem.GetCountByCity();
            if (countByCity.Count > 0)
            {
                Console.WriteLine("Count by City:");
                foreach (var kvp in countByCity)
                {
                    Console.WriteLine($"City: {kvp.Key}, Count: {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }

        private static void GetCountByState()
        {
            Dictionary<string, int> countByState = addressBookSystem.GetCountByState();
            if (countByState.Count > 0)
            {
                Console.WriteLine("Count by State:");
                foreach (var kvp in countByState)
                {
                    Console.WriteLine($"State: {kvp.Key}, Count: {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }
    }
}
