
using System;
using System.Collections.Generic;

namespace Restaurant.Library
{
    internal class Order
    {
        // hold items and prices and additionally total

        internal List<Product> AllProductsOnOrder
        // each item and price/cost
        // each product ordered and its price
        {
            get;
            set;
        }

        private User WhoOrdered  // link each order to one specific customer
                                 // probably other people without access should not see who ordered what (protect privacy)
        {
            get;

            set;
        }
        public Order(Product productAndPrice, User userPlacingOrder)
        {
            AllProductsOnOrder.Add(productAndPrice);
            // should add to a list of Dictionaries
            // Each dictionary has a product name (unique) and a potentionally duplicate price

            // need a list to spit out the line by line summary of the order

            // can total the prices to give the order total

            // need to handle user linked to order in another method
            // also save Order on user to keep order history on each user
            // each user should have an order history member
            WhoOrdered = userPlacingOrder;
        }

       
        // calculate sum of all products in the order
        public decimal Total
        {
            get
            {
                return Total;
            }

            set
            {
                foreach (var product in AllProductsOnOrder)
                        Total += product.Price;
            }
        }
    }
}
