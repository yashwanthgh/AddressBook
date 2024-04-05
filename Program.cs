using AddressBookProject;

public class Program
{
    public static void Main(string[] args)
    {
        AddressBookManager addressBookManager = new();

        while (true)
        {
            Console.WriteLine("** Address Book **");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addressBookManager.AddContact();
                    break;
                case "2":
                    addressBookManager.EditContact();
                    break;
                case"3":
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
}