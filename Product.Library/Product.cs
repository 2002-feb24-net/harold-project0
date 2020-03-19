using System;
using System.Collections.Generic;

namespace Product.Library
{
    public class Product
    {
        // make an object to hold wings and prices, drinks and prices
        public Dictionary<string, decimal> ProductAndPrice
        {
            get
            {
                return ProductAndPrice;
            }

            set
            {
                foreach (var entry in value)
                {
                    ProductAndPrice.Add(entry.Key, entry.Value);
                }
            }
        }
        public Product(Dictionary<string, decimal> productAndPrice)
        {
            // ex: Product wings = {spicy eight count, 10}, {mild eight count, 10}
            ProductAndPrice = productAndPrice;
            // never empty wings/drinks list bc in constructor
        }

        // second constructor, build the dictionary

        public Product(string product, decimal price)
        {
            ProductAndPrice.Add(product, price);
        }


        //public Stock


    }
}
