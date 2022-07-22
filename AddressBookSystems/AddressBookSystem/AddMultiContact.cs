using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddMultiContact
    {
        // creating New List to Add Data Information
        public List<AddressBooks> AddressList;

        public AddMultiContact()
        {
            // Creating Instance of AddressList 
            AddressList = new List<AddressBooks>();
        }

        // Defing Method to Add New Contact
        public void AddMultiNewContact()
        {
            // Taking Output (Contact Deatail) From User to Add In Adreess Book 
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
            long Phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email Address : ");
            string Email_Address = Console.ReadLine();

            // Creating Instance & Passing Parameter
            AddressBooks addressdetails = new AddressBooks(First_Name, Last_Name, Address, City, State, Zip_Code, Phone_Number, Email_Address);


            // Define Logic if else to Check Contact Details Present or not If not Then Add Contact Detail 
            int CheckDetails = 0;
            if (AddressList.Count > 0)  // count the Address present in AddressList
            {
                foreach (AddressBooks address in AddressList)
                {
                    if (address.First_Name == First_Name && address.Last_Name == Last_Name)
                    {
                        CheckDetails = 1; // to check present or not if present then assign CheckDetails is 1.
                        Console.WriteLine("Name : {0} {1}", address.First_Name, address.Last_Name);
                    }
                }
            }
            // if else to check present or not if present go to if block or not then go to else block
            if (CheckDetails == 1)
            {
                Console.WriteLine("The Name You Enter is Already Present in Address Book");
            }
            else
            {
                AddressList.Add(addressdetails); // add Details in Address Book 
            }
        }
        // Defing Method to Display Contact Details after Add New Contact by User
        public void DisplayContactDetails()
        {
            if (AddressList.Count > 0)
            {
                // using foreach to acess the Details Present in Address Book..
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

        // Defing Method to Edit Contact Details
        public void EditContactDetails()
        {
            Console.WriteLine("Enter The First Name for Edit The Contact");
            string First_Name = Console.ReadLine();
            foreach (AddressBooks address in AddressList)
            {
                if (address.First_Name == First_Name)
                {
                    // Taking Input by User Which Field want to Edit 
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. state");
                    Console.WriteLine("6. Zip Code ");
                    Console.WriteLine("7. Phone Number ");
                    Console.WriteLine("8. Email Address");
                    Console.WriteLine("Enter the Field you Want to Edit ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    // using Switch to Edit The Field Choose By User
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("New First Name : ");
                            string New_First_Name = Console.ReadLine();
                            address.First_Name = New_First_Name;
                            break;
                        case 2:
                            Console.Write("New Last Name : ");
                            string New_Last_Name = Console.ReadLine();
                            address.Last_Name = New_Last_Name;
                            break;
                        case 3:
                            Console.Write("New Address : ");
                            string New_Address = Console.ReadLine();
                            address.Address = New_Address;
                            break;
                        case 4:
                            Console.Write("New City : ");
                            string New_City = Console.ReadLine();
                            address.City = New_City;
                            break;
                        case 5:
                            Console.Write("New State : ");
                            string New_State = Console.ReadLine();
                            address.State = New_State;
                            break;
                        case 6:
                            Console.Write("New Zip Code : ");
                            int New_Zip_Code = Convert.ToInt32(Console.ReadLine());
                            address.Zip_Code = New_Zip_Code;
                            break;
                        case 7:
                            Console.Write("New Phone Number : ");
                            long New_Ph_Number = Convert.ToInt64(Console.ReadLine());
                            address.Ph_Number = New_Ph_Number;
                            break;
                        case 8:
                            Console.Write("New Email Address : ");
                            string New_Email = Console.ReadLine();
                            address.Email = New_Email;
                            break;
                        default:
                            Console.WriteLine(" Please Enter Correct Choice");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine(" Your Input Didn't Present in the Address Books");
                }
            }

        }

        public void DeleteContactDetails()
        {
            // Taking Input(First Name) From User to Delete Contact Details.
            Console.WriteLine("Enter The First Name of Contact Detail You Want to Delete : ");
            String DeleteContacts = Console.ReadLine();   // storing Input Taken by User
            foreach (AddressBooks Delete in AddressList)
            {
                if (Delete.First_Name == DeleteContacts)
                {
                    AddressList.Remove(Delete);
                    Console.WriteLine("Contact Details Removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input First Name You Enter Not Present in Address Book");
                }
            }
        }
    }
}
