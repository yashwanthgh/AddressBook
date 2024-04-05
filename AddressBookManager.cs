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
    public void ListContacts()
    {
        addressBook.ListContacts();
    }
    public void Menu()
    {
        Console.WriteLine("\n** Address Book Menu **");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Edit Contact");
        Console.WriteLine("3. List Contacts");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");

        string? choice = Console.ReadLine();
        int choiceInt;

        while (!int.TryParse(choice, out choiceInt) || choiceInt < 1 || choiceInt > 4)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            choice = Console.ReadLine();
        }

        switch (choiceInt)
        {
            case 1:
                AddContact();
                break;
            case 2:
                EditContact();
                break;
            case 3:
                ListContacts();
                break;
            case 4:
                Console.WriteLine("Exiting Address Book.");
                break;
        }
    }
    public void Run()
    {
        while (true)
        {
            Menu();
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}