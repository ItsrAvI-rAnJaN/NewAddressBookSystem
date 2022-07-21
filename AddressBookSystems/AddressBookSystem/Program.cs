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

            // Creating Instance obj..
            AddressBooks objDetails = new AddressBooks("Ravi","Ranjan","Dlf Phase 4","Gurugram","Harayana",122002,9319964621,"Ezekie.ez@gmail.com");
            // Calling method
            objDetails.Displaydetails();
            Console.ReadKey();
        }
    }
}