using System;
using System.Collections.Generic;
using Restaurant.DataAccess;
using Restaurant.DataAccess.Models;
using Restaurant.Library;
// Author: Haroldo Altamirano
// TO BE IMPLEMENTED:
// Exception handling, unit tests, order history, search of customers, order details table, secretconfiguration, inventory decrement on order placement, pick product quantity on order

    // dbcontext.Customers.Where(condition)

    // IMPLEMENTED FOR FRIDAY: SQL handles inventory decrement on order placement

// FOCUS:
// SOLID
//      ex: Small methods, versatility from returning whole row objects instead of just their data, interfaces rather than direct connections b/w data access project and library classes
//separation of concerns (keep data access implementation in another project)
// OOP
//      No hardcoded static values, variables displayed and options (product options) are loaded from DB data
//       Extendable: Library and DataAccess classes and Database structure support many different types of stores
//                      Can add a store description and products and inventory in under 10 minutes
//                          changing between stores in the program can be done in the first 30 seconds of execution
// GIT
//      Incremental development with frequent backups, commits only once code had no compile errors, task completed and WIP functionality noted in commits
//      37 commits, separate from other repositories/unrelated files, deprecated projects deleted
// Disposable connections
//      connections to database are closed through using statements. Connections do not remain open for longer than a method call




namespace Restaurant.ConsoleApp   
{
    class Program
    {
        static void Main(string[] args)
        {
            var s_Stores = Menu.StoreMenu(); // pick store
            var sDAL = new StoreDAL(); // access db about stores
            Store store = new Store();
            sDAL.InitializeStore(s_Stores, store);
   
            Customer customer = new Customer("default", "default", "default1231!");
            bool loggedIn;
            do
            {
                loggedIn = false;

                Menu.UserMenu(s_Stores);
                var loginOrRegister = Convert.ToInt32(Console.ReadLine());
                switch (loginOrRegister)
                {
                    case 1:
                        //login
                        customer = Login();
                        loggedIn = true;

                        break;
                    case 2:
                        //register
                        AddCustomerToDB(); // has prompts to get user details (name, username, password)
                        customer = Login();
                        loggedIn = true;


                        break;
                    default:
                        Console.WriteLine("Error: you must choose 1 or 2");
                        break;
                }
            } while (loggedIn == false);
            // now logged in with customer object
            // place an order
            Console.WriteLine("Place an order");
            AddOrder(customer, store);
            // 





            var chosenStore = new Store();
            chosenStore.StoreId = 1;
            /*var customer = new Customer("Jonny water");*/
            /*AddOrder(customer, chosenStore);*/



          /*  Console.WriteLine("Hello World!");

            Console.WriteLine("Place a new order");
            AddCustomerToDB();
            Console.WriteLine("All Customers in Database");
            DisplayAllCustomersFromDB();
            // display all customers from database*/
        }

        static void AddCustomerToDB()
        {
            Console.WriteLine("Add a customer");
            Console.WriteLine("Write full name");
            var inputName = Console.ReadLine();
            Console.WriteLine("Write a unique username");
            var username = Console.ReadLine();
            Console.WriteLine("Write a password...");
            Console.WriteLine("Must have at least 8 characters and 1 special character ex: !@#$%^&*");
            var password = Console.ReadLine();
            var newCustomer = new Customer(inputName, username, password);
            var CDAL = new CustomerDAL();
            CDAL.SaveCustomer(newCustomer);
        }

        static void DisplayAllCustomersFromDB()
        {
            var CDAL = new CustomerDAL();
            var CustomersList = CDAL.LoadAllCustomers();
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
            var Total =newOrder.Total;
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
            
        }
        static Customer Login()
        {
            /*try
            {*/
                Console.WriteLine("Enter your username");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password");
                var password = Console.ReadLine();

                //check if matches unique registered user,password combo
                var cDAL = new CustomerDAL();
                /*try
                {*/
                var customerID = cDAL.GetCustomerID(username, password);
                /*}*/

                var c_Customers = cDAL.LoadCustomerByID(customerID);

                // load all data from db into c# customer object
                var loggedInCustomer = new Customer(c_Customers.FullName, c_Customers.Username, c_Customers.Password);
                loggedInCustomer.CustomerId = customerID;
         /*   }*/
            /*catch
            {
                var ex = new System.InvalidOperationException();
            }*/
            return loggedInCustomer;







        }

        

    }
}
