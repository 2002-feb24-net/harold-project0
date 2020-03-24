using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interface
{
    public interface IDataStore
    {
        public int StoreId { get; } // can't set an identity column
        public string StoreName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}
