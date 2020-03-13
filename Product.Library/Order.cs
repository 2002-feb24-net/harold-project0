
using System;
using System.Collections.Generic;

namespace Product.Library
{
    class Order
    {
        // hold items and prices and additionally total

        public List<Product> ProductAndPriceList
            // each item and price/cost
        {
            get;
            set;
        }

        public User WhoOrdered  // link each order to one specific customer
        {
            get;

            set;
        }
        public Order(Product productAndPrice, User whoIsOrdering)
        {
            ProductAndPriceList.Add(productAndPrice);
            // should add to a list of Dictionaries
            // Each dictionary has a product name (unique) and a potentionally duplicate price

            // need a list to spit out the line by line summary of the order

            // can total the prices to give the order total

            WhoOrdered = whoIsOrdering;
        }

        public decimal Total
        {
            get {
                return Total;
            }

            set
            {
                foreach (var product in ProductAndPriceList)
                {

                    foreach (var productAndPrice in product.ProductAndPrices)
                    {
                       Total += productAndPrice.Value; 
                    }
                }
            }
        }
    }
}