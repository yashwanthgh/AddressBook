using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private string PhoneNumber;
        private string Email;

        Contact() { }

        Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string emial)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = emial;
        }

        // Setters
        public void setFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.LastName = lastName;
        }
        public void setAddress(string address)
        {
            this.Address = address;
        }
        public void setCity(string city)
        {
            this.City = city;
        }
        public void setState(string state)
        {
            this.State = state;
        }
        public void setZip(string zip)
        {
            this.Zip = zip;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        // Getters
        public string getFirstName()
        {
            return this.FirstName;
        }
        public string getLastName()
        {
            return this.LastName;
        }
        public string getAddress() 
        { 
            return this.Address;
        }
        public string getCity()
        {
            return this.City;
        }
        public string getState()
        {
            return this.State;
        }
        public string getZip()
        {
            return this.Zip;
        }
        public string getPhoneNumber()
        {
            return this.PhoneNumber;    
        }
        public string getEmail()
        {
            return this.Email;
        }
    }
}
