using AddressBookProject;
using System.Text.RegularExpressions;

public class AddressBookManager
{
    private AddressBook addressBook;
    private AddressBookSystem addressBookSystem;

    public AddressBookManager(AddressBook addressBook, AddressBookSystem addressBookSystem)
    {
        this.addressBook = addressBook;
        this.addressBookSystem = addressBookSystem;
    }

    public void AddContact()
    {
        Console.WriteLine("Enter Contact Details:");

        string firstName = GetValidatedInput("First Name: ", @"^[A-Z][a-zA-Z]{2,}$");
        string lastName = GetValidatedInput("Last Name: ", @"^[A-Z][a-zA-Z]{2,}$");
        string address = Console.ReadLine();
        string city = Console.ReadLine();
        string state = Console.ReadLine();
        string zip = Console.ReadLine();
        string phoneNumber = GetValidatedInput("Phone Number: ", @"^[0-9]{10}$");
        string email = GetValidatedInput("Email: ", @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        addressBook.AddContact(newContact);
        addressBookSystem.AddPersonToCityDictionary(newContact);
        addressBookSystem.AddPersonToStateDictionary(newContact);
        Console.WriteLine("Contact added successfully!");
    }

    private string GetValidatedInput(string prompt, string pattern)
    {
        Regex regex = new Regex(pattern);
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (!regex.IsMatch(input))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (!regex.IsMatch(input));
        return input;
    }


    public void EditContact()
    {
        Console.WriteLine("Enter name of the contact to edit:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        addressBook.EditContact(firstName, lastName);
    }

    public void DeleteContact()
    {
        Console.WriteLine("Enter name of the contact to delete:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        if (addressBook.DeleteContact(firstName, lastName))
        {
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }
}