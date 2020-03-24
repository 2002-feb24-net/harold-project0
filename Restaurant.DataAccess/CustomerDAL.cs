using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess.Models;
using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DataAccess
{
    public class CustomerDAL
        //customer data access library
    {
        public void SaveCustomer(ICustomer customer)
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            var C_Customer = new Customers();
            // add BusinessLogic Customer to DbCustomer
            C_Customer.FullName = customer.FullName;


            context.Add(C_Customer);
            context.SaveChanges();
        }

        public List<Customers> LoadCustomers()
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            return context.Customers.ToList();

        }
    }
}
