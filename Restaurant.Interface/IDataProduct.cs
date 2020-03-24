using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interface
{
    public interface IDataProduct
    {
        public int ProductId { get; } // cannot set an identity column
        public string ProductName { get; set; }
        public decimal? Cost { get; set; }
    }
}
