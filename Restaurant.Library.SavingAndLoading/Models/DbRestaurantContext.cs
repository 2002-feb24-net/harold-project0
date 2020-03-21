using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurant.Library.SavingAndLoading.Models
{
    public partial class DbRestaurantContext : DbContext
    {
        public DbRestaurantContext()
        {
        }

        public DbRestaurantContext(DbContextOptions<DbRestaurantContext> options)
            : base(options)
        {
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
