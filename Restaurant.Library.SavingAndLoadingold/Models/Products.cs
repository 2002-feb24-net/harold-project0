using System;
using System.Collections.Generic;

namespace Restaurant.Library.SavingAndLoading.Models
{
    public partial class Products
    {
        public Products()
        {
            Inventorys = new HashSet<Inventorys>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Cost { get; set; }

        public virtual ICollection<Inventorys> Inventorys { get; set; }
    }
}
