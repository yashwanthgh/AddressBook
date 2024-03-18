using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book!");
            Console.WriteLine("To add a new contact Press 1");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ContactController contactController = new ContactController();
                    contactController.AddNewContact();
                    break;
            }
        }
    }
}
