using System;
using System.Collections.Generic;
using Restaurant.DataAccess;
using Restaurant.DataAccess.Models;
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

            // login (pick a customer object)



            // pick a store to shop from based on a list



            var chosenStore = new Store();
            chosenStore.StoreId = 1;
            var customer = new Customer("Jonny water");
            AddOrder(customer, chosenStore);


            
            
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

        static void AddOrder(Customer customer, Store store)
        {
            // do a while loop to keep asking for customer to buy product
            Console.WriteLine("Add an order");
            Console.WriteLine("Your store has the following to choose from");



            var PDAL = new ProductDAL();
            var productIDsInStock = PDAL.LoadProductIDsFromStoreInStock(store); // need to load product ids for the specific store here

            // select products where productid matches one of the items(ids) in the list
            foreach (var productID in productIDsInStock)
            {
                var Product_products = PDAL.LoadProductByID(productID);

                //output list of products
                Console.WriteLine(Product_products.ProductId + " " + Product_products.ProductName + " " + Product_products.Cost);
            }
            Console.Write("Select from the above...");
            Console.WriteLine("For example: 7");
            var productIDChosen = Convert.ToInt32(Console.ReadLine());

            // if input matches a product id TO BE IMPLEMENTED

            // get product details and add/pass that to the order
            var P_products = PDAL.LoadProductByID(productIDChosen);
            var productToBeOrdered = new Product(P_products.ProductName, P_products.Cost);



            var newOrder = new Order(productToBeOrdered, customer);
            string Total = Convert.ToString(newOrder.Total);
            // Display total cost
            Console.WriteLine("Your order total is " + Total);
            Console.WriteLine("Do you confirm the purchase? (y/n)");
            var input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {
                //save order in db
                var oDAL = new OrderDAL();
                oDAL.SaveOrder(newOrder, customer, store);
            }
            else
            {
                Console.WriteLine("Order cancelled.");
                Console.WriteLine("You will not be charged");
                return;
            }

            /*static Customer Login()
            {

                //return 
            }*/
            
        }
        
    }
}
