using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess.Models;
using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DataAccess
{
    public class StoreDAL
        //customer data access library
    {
        public void SaveStore(IDataStore store)
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            var S_Stores = new Stores();
            // add BusinessLogic Store to DbStores
            S_Stores.StoreName = store.StoreName;
            S_Stores.StreetAddress = store.StreetAddress;
            S_Stores.City = store.City;
            S_Stores.State = store.State;
            S_Stores.Zipcode = store.Zipcode;


            context.Add(S_Stores);
            context.SaveChanges();
        }

        public List<Stores> LoadStores()
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            return context.Stores.ToList();

        }
    }
}
