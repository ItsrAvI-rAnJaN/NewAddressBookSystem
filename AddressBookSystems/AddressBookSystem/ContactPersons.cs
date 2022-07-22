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
                            Console.WriteLine("Please Enter Correct Choice");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Your Input Didn't Present in the Address Books");
                }
            }
        }
        // crearing Method fo Deleting Contact..
        public void DeleteContactDetails()
        {
            // Taking Input(First Name) From User to Delete Contact Details.
            Console.Write("Enter The First Name of Contact Detail You Want to Delete : ");
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
