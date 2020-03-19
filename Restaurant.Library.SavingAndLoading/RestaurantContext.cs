using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Library;

namespace Restaurant.Library.SavingAndLoading
{
    class RestaurantContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }

        // Need to add other classes that will be stored and loaded from database

    }
}
