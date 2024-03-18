using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactController
    {
        static ArrayList contactList = new ArrayList();

        public void AddNewContact()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter city name:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state:");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zip:");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string emial = Console.ReadLine();
            contactList.Add(new Contact(firstName,  lastName, address, city, state, zip, phoneNumber, emial));
            Console.WriteLine($"Contact of {firstName} {lastName} added");
        }

    }
}
