using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess.Models;
using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DataAccess
{
    public class ProductDAL
        //customer data access library
    {
        public void SaveProduct(IDataProduct product)
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            var P_Products = new Products();
            // add BusinessLogic Customer to DbCustomer
            P_Products.ProductName = product.ProductName;
            P_Products.Cost = product.Cost;


            context.Add(P_Products);
            context.SaveChanges();
        }

        public List<Products> LoadProducts()
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            return context.Products.ToList();

        }
    }
}
