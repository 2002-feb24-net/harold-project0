
using System;
using System.Collections.Generic;

namespace Product.Library
{
    internal class Order
    {
        // hold items and prices and additionally total

        public List<Product> ProductAndPriceList
        // each item and price/cost
        {
            get;
            set;
        }

        /*private User WhoOrdered  // link each order to one specific customer
            // probably other people without access should not see who ordered what (protect privacy)
        {
            get;

            set;
        }*/
        public Order(Product productAndPrice)
        {
            ProductAndPriceList.Add(productAndPrice);
            // should add to a list of Dictionaries
            // Each dictionary has a product name (unique) and a potentionally duplicate price

            // need a list to spit out the line by line summary of the order

            // can total the prices to give the order total

            // need to handle user linked to order in another method
            // also save Order on user to keep order history on each user
            // each user should have an order history member
        }

       /* need to decouple this class from user so deleted this method
         ivate void AddOrderToHistory()
            {
            WhoOrdered.AddOrderToHistory(this);

            }*/

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
