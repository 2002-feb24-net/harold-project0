using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Library
{
    public class Store
    {
        string Location { get; set; }

        List<Product> ProductsSold { get; set; }
        // to avoid someone trying to order burgers from Pizza restaurant
        // need only check Product.Name for verification, but added whole product class to allow different operations
        // for example: can list all products of x price

        Dictionary<Product,int> ProductAndInventory { 
            get { return ProductAndInventory; }
            set 
            {
                foreach (var item in value)
                {
                    if (item.Value < 0)
                    {
                        throw new ArgumentOutOfRangeException($"Cannot have negative inventory for product: {item.Key}");
                    }


                }
            }
        }


    }
}
