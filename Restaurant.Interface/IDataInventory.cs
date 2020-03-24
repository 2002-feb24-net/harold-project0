using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interface
{
    public interface IDataInventory
    {
        public int InventoryId { get; } // cannot set an identity column
        public int? Quantity { get; set; }
        public int? StoreId { get; set; }
        public int ProductId { get; set; }
    }
}
