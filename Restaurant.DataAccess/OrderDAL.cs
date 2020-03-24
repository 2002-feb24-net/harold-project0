using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess.Models;
using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DataAccess
{
    public class OrderDAL
        //customer data access library
    {
        public void SaveOrder(IDataOrder order, ICustomer customer /*IStore store*/)
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            var O_Orders = new Orders();
            // add BusinessLogic Order to DBOrders
           /* O_Orders.Customer = 


            context.Add(O_Orders);
            context.SaveChanges();*/
        }

        public List<Customers> LoadCustomers()
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            return context.Customers.ToList();

        }
    }
}
