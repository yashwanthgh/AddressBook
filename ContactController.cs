using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactController
    {
        static Contact contact;
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

        public void EditContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string firstName = Console.ReadLine();
            contact = Details(firstName);
            if (contact != null)
            {
                string response = EditSelectedDetail(EditSelectedDetailPrompt());
                Console.WriteLine(response);
            }
            else
            {
                Console.WriteLine("Enter valid name");
            }
        }


        private Contact Details(string firstName)
        {
            foreach (Contact contact in contactList)
            {
                if (contact.getFirstName().Equals(firstName))
                {
                    return contact;
                }
            }
            return null;
        }

        private int EditSelectedDetailPrompt() 
        {
            Console.WriteLine("To edit first name press 1");
            Console.WriteLine("To edit last name press 2 ");
            Console.WriteLine("To edit address press 3");
            Console.WriteLine("To edit city press 4");
            Console.WriteLine("To edit state press 5");
            Console.WriteLine("To edit zip press 6");
            Console.WriteLine("To edit phone number press 7");
            Console.WriteLine("To edit email press 8");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private string EditSelectedDetail(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new first name: ");
                    string firstName = Console.ReadLine();
                    contact.setFirstName(firstName);
                    return ($"Name changed to {firstName}");
                    
                case 2: 
                    Console.WriteLine("Enter new last name");
                    string lastName = Console.ReadLine();
                    contact.setFirstName(lastName);
                    return ($"Name changed to {lastName}");
                    
                case 3:
                    Console.WriteLine("Enter new address: ");
                    string address = Console.ReadLine();
                    contact.setFirstName(address);
                    return ($"Name changed to {address}");
                    
                case 4:
                    Console.WriteLine("Enter new city: ");
                    string city = Console.ReadLine();
                    contact.setFirstName(city);
                    return ($"Name changed to {city}");
                    
                case 5:
                    Console.WriteLine("Enter new state: ");
                    string state = Console.ReadLine();
                    contact.setFirstName(state);
                    return ($"Name changed to {state}");
                    
                case 6:
                    Console.WriteLine("Enter new zip: ");
                    string zip = Console.ReadLine();
                    contact.setFirstName(zip);
                    return ($"Name changed to {zip}");
                    
                case 7:
                    Console.WriteLine("Enter new phone number: ");
                    string phoneNumber = Console.ReadLine();
                    contact.setFirstName(phoneNumber);
                    return ($"Name changed to {phoneNumber}");
                    
                case 8:
                    Console.WriteLine("Enter new email: ");
                    string email = Console.ReadLine();
                    contact.setFirstName(email);
                    return ($"Name changed to {email}");
                    
            }
            return ("Enter valid Option");
        }

    }
}
