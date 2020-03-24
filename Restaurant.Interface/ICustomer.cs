using System;

namespace Restaurant.Interface
{
    public interface ICustomer
    {
        public int CustomerId { get; } // Can't set identity column
        string FullName{get; set;}
    }
}
