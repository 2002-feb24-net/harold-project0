using System;
using System.Collections.Generic;

namespace Restaurant.DataAccess.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public decimal? Total { get; set; }
        public DateTime TimeOrdered { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Stores Store { get; set; }
    }
}
