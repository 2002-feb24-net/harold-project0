using System;
using System.Collections.Generic;

namespace Product.Library
{
    public class Product
    {
        // make an object to hold wings and prices, drinks and prices
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        // previously had a dictionary, but the class already links Name and Price so do not need a dictionary

        public Product (string name, decimal price)
        {
            Name = name;
            Price = price;

            //DecrementInventory();
        }




    }
}
