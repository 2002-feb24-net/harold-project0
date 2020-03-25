using System;

namespace Restaurant.Interface
{
    public interface ICustomer
    {
        public int CustomerId { get; set; }
        string FullName{get; set;}
    }
}
