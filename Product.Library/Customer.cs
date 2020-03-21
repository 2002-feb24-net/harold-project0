using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Library
{
    class Customer : User
    {
        // implements username and password validation from User
        // have to override username methods because using Full name ("FirstName LastName")
        // otherwise methods would talk about username when user inputs full name
        string FullName
        {
            get { return FullName; }
            set { FullName = InputUserValidation(value); }
        }

  

        Customer( string fullname, string uniqueUsername, string password)
            // registers a customer
        {
            FullName = fullname;

            Username = uniqueUsername;
            Password = password;

        }

        static string SearchCustomerByName (string cname)
        {
            //connect to database get loaded list
            throw new NotImplementedException();
        }


    }
}
