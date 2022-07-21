using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Creating Class 
    public class AddressBooks
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;                                   // Taking Global Variables to Store Details
        public int Zip_Code;
        public long Ph_Number;
        public string Email;

        // Creating Constructor
        public AddressBooks(string first_Name, string last_Name, string address, string city, string state, int zip_Code, long ph_Number, string email)
        {
            this.First_Name = first_Name;
            this.Last_Name = last_Name;
            this.Address = address;
            this.City = city;
            this.State = state;                               // Set Class Variables 
            this.Zip_Code = zip_Code;
            this.Ph_Number = ph_Number;
            this.Email = email;
        }

        public void Displaydetails()
        {
            Console.WriteLine("\n Contact Details:- ");
            Console.WriteLine(" Name: {0} {1} ",First_Name, Last_Name);
            Console.WriteLine(" Address: {0}, {1}, {2} ",Address,City,State);
            Console.WriteLine(" Zip Code: {0}",Zip_Code);
            Console.WriteLine(" Ph. Number: {0}",Ph_Number);
            Console.WriteLine(" Email Address: {0}",Email);
        }

    }
}
