using System;

namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO ADDRESS BOOK SYSTEM");
            Console.WriteLine("\t\t\t\t################################################");
            int Choice;
            do
            {
                Console.WriteLine("\n0.Exit");
                Console.WriteLine("1. Get Contact Present in Address Book ");
                Console.WriteLine("2. Add New Contact to Address Book");
                Console.WriteLine("3. Edit Contact Present in Address Book");
                Console.WriteLine("4. Delete Contact Using Person's First Name");
                Console.WriteLine("5. Add Multiple Contact into Address Books");
                Console.Write("\nEnter Your Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        // Creating Instance obj..
                        AddressBooks objDetails = new AddressBooks("Ravi", "Ranjan", "Dlf Phase 4", "Gurugram", "Harayana", 122002, 9319964621, "Ezekie.ez@gmail.com");
                        // Calling method
                        objDetails.Displaydetails();
                        break;
                    case 2:
                        ContactPersons objaddnewcontact = new ContactPersons();
                        objaddnewcontact.AddNewContact();
                        objaddnewcontact.DisplayContactDetails();
                        break;
                    case 3:
                        // creating instance & call the Method to Add New Contact
                        ContactPersons objeditcontact = new ContactPersons();
                        objeditcontact.AddNewContact();
                        objeditcontact.DisplayContactDetails();

                        // for Editing Contact & call the Method of Editing Contact
                        Console.WriteLine("Edit Contact Using first Name ? 1: Y/N");
                        Console.Write("Enter Your Choice : ");
                        string Choice_3 = Console.ReadLine();
                        if (Choice_3 == "Y")
                        {
                            objeditcontact.EditContactDetails();
                            objeditcontact.DisplayContactDetails();
                        }
                        break;
                    case 4:
                        // Creting instance of call the Method to Edit & Delete Contactg Details.
                        ContactPersons objDeleteAddress = new ContactPersons();
                        objDeleteAddress.AddNewContact();
                        objDeleteAddress.DisplayContactDetails();

                        // Asking to Edit Contact if Y then Proceed.
                        Console.WriteLine("Edit Contact Using first Name ? Y/N");
                        Console.Write("Enter Your Choice : ");
                        string Choice4_1 = Console.ReadLine();
                        if (Choice4_1 == "Y")
                        {
                            objDeleteAddress.EditContactDetails();
                            objDeleteAddress.DisplayContactDetails();
                        }

                        // Asking to delete the Contact Details if Y then Proceed..
                        Console.WriteLine("Delete Contact Using First Name ? Y/N");
                        Console.Write("Enter Your Choice : ");
                        string Choice4_2 = Console.ReadLine();
                        if (Choice4_2 == "Y")
                        {
                            objDeleteAddress.DeleteContactDetails();
                        }
                        else
                        {
                            objDeleteAddress.DisplayContactDetails();
                        }
                        break;
                    case 5:
                        AddMultiContact objMultiContact = new AddMultiContact();
                    Add:
                        Console.WriteLine("Enter Details Below ?: Y/N ");
                        Console.Write("Enter Your Choice : ");
                        string Choice5_1 = Console.ReadLine();
                        if (Choice5_1 == "Y")
                        {
                            objMultiContact.AddMultiNewContact();
                            objMultiContact.DisplayContactDetails();
                            goto Add;
                        }
                    // Asking User to Edit Contact Details.
                    Edit:
                        if (objMultiContact.AddressList.Count > 0) //Check no. of Contact is greater than 0.
                        {
                            Console.WriteLine("Edit Contact Using first Name ? Y/N");
                            Console.Write("Enter Your Choice : ");
                            string Choice5_2 = Console.ReadLine();
                            if (Choice5_2 == "Y")
                            {
                                objMultiContact.EditContactDetails();
                                objMultiContact.DisplayContactDetails();
                                goto Edit;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact Details Not Present in Address Book");
                        }
                    Delete:
                        if (objMultiContact.AddressList.Count > 0)
                        {
                            // Asking to delete the Contact Details if Y then Proceed..
                            Console.WriteLine("Delete Contact Using First Name ? Y/N");
                            Console.Write("Enter Your Choice : ");
                            string Choice5_2 = Console.ReadLine();
                            if (Choice5_2 == "Y")
                            {
                                objMultiContact.EditContactDetails();
                                objMultiContact.DisplayContactDetails();
                                goto Delete;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact Details Not Present in Address Book for Deletion..");

                        }
                        break;

                    default:
                        Console.WriteLine("Enter Correct Choice");
                        break;
                }

            }
            while (Choice != 0);


           
            Console.ReadKey();
        }
    }
}