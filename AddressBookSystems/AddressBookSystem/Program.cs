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
                Console.WriteLine("1.Get Contact Present in Address Book ");
                Console.WriteLine("2. Add New Contact to Address Book");
                Console.WriteLine("3. Edit Contact Present in Address Book");
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
                    default:
                        Console.WriteLine(" Enter Correct Choice");
                        break;
                }

            }
            while (Choice != 0);


           
            Console.ReadKey();
        }
    }
}