using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class ContactPersons
    {

        List<AddressBooks> AddressList;

        public ContactPersons()
        {
            AddressList = new List<AddressBooks>();
        }
        public void AddNewContact()
        {
            Console.WriteLine("Fill The Details Given Below: ");
            Console.Write("First Name : ");
            string First_Name = Console.ReadLine();
            Console.Write("Last Name : ");
            string Last_Name = Console.ReadLine();
            Console.Write("Address : ");
            string Address = Console.ReadLine();
            Console.Write("City : ");
            string City = Console.ReadLine();
            Console.Write("State : ");
            string State = Console.ReadLine();
            Console.Write("Zip Code : ");
            int Zip_Code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number : ");
            long Ph_Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email Address : ");
            string Email = Console.ReadLine();

            AddressBooks addressdetails = new AddressBooks(First_Name, Last_Name, Address, City, State, Zip_Code, Ph_Number, Email);



            if (AddressList.Contains(addressdetails))
            {
                Console.WriteLine("Details you Enter is Already Present");
            }

            else
            {
                AddressList.Add(addressdetails);
            }
        }
        public void DisplayContactDetails()
        {
            foreach (AddressBooks address in AddressList)
            {
                // printg Details..
                Console.WriteLine("\nContact Details are :-");
                Console.WriteLine("Name : {0} {1}", address.First_Name, address.Last_Name);
                Console.WriteLine("Address : {0}, {1} ({2})", address.Address, address.City, address.State);
                Console.WriteLine("Zip Code : {0}", address.Zip_Code);
                Console.WriteLine("Ph. Number : {0}", address.Ph_Number);
                Console.WriteLine("Email Address : {0}", address.Email);
            }
        }
    }
}
