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
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addressBookManager.AddContact();
                    break;
                
                case "2":
                    Console.WriteLine("Exiting Address Book");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}