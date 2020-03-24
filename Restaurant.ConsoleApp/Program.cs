using System;
using System.Collections.Generic;
using Restaurant.DataAccess;
using Restaurant.Library;

namespace Restaurant.ConsoleApp   
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Place a new order");

            // display all customers from database
            
        }

        void AddCustomerToDB()
        {
            Console.WriteLine("Add a customer");
            Console.WriteLine("Write full name");
            var input = Console.ReadLine();
            var newCustomer = new Customer(input);
            var CDAL = new CustomerDAL();
            CDAL.SaveCustomer(newCustomer);
        }

        void DisplayAllCustomersFromDB()
        {
            var CDAL = new CustomerDAL();
            var CustomersList = CDAL.LoadCustomers();
            foreach (var OneCustomers in CustomersList)
            {
                Console.WriteLine(OneCustomers.FullName);
            }
        }

        
    }
}
