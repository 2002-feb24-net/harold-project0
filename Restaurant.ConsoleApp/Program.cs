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
            AddCustomerToDB();
            Console.WriteLine("All Customers in Database");
            DisplayAllCustomersFromDB();
            // display all customers from database
            
        }

        static void AddCustomerToDB()
        {
            Console.WriteLine("Add a customer");
            Console.WriteLine("Write full name");
            var input = Console.ReadLine();
            var newCustomer = new Customer(input);
            var CDAL = new CustomerDAL();
            CDAL.SaveCustomer(newCustomer);
        }

        static void DisplayAllCustomersFromDB()
        {
            var CDAL = new CustomerDAL();
            var CustomersList = CDAL.LoadCustomers();
            foreach (var OneCustomers in CustomersList)
            {
                Console.WriteLine(OneCustomers.FullName);
            }
        }

        void AddOrder(Customer customer, Store store)
        {
            // do a while loop to keep asking for customer to buy product
            Console.WriteLine("Add an order");
            Console.WriteLine("Your store has the following to choose from");

            var SDAL = new StoreDAL();
            var ListOfStores = SDAL.LoadStores(); // need to load product ids for the specific store here instead. Placeholder
            foreach (var item in ListOfStores)
            {
                Console.WriteLine(item);
            }
            Console.Write("Select from the above...");
            var product = Console.ReadLine();


            // get product cost and add that to the order total
            // placeholder hardcode for now
            /*var productAndCost

            var newOrder = new Order();


            var ODAL = new OrderDAL();*/
            
        }
        
    }
}
