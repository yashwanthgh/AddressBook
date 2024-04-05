using AddressBookProject;

public class AddressBookManager
{
    private AddressBook addressBook;

    public AddressBookManager()
    {
        addressBook = new AddressBook();
        addressBook.AddContact(new Contact("John", "Doe", "123 Main St", "Anytown", "CA", "12345", "555-123-4567", "john.doe@example.com"));
        addressBook.AddContact(new Contact("Jane", "Smith", "456 Elm St", "Big City", "NY", "98765", "555-789-0123", "jane.smith@example.com"));
    }
    public void AddContact()
    {
        Console.WriteLine("Enter Contact Details:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State: ");
        string state = Console.ReadLine();
        Console.Write("Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        addressBook.AddContact(newContact);
        Console.WriteLine("Contact added successfully!");
    }
    public void EditContact()
    {
        Console.WriteLine("Enter name of the contact to edit:");
        Console.Write("First Name: ");
        string? firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string? lastName = Console.ReadLine();
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
    public void ListContacts()
    {
        addressBook.ListContacts();
    }
   
}