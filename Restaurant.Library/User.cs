using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Library
{
    public abstract class User
    {
        internal virtual string Username
        {
            get { return Username; }
            set { Username = InputUserValidation(value); }
        }
        protected string Password
        {
            get { return Password; }
            set { }
        }

  

        internal string InputUserValidation(string username)
        {
            if (username == ""
                || username == null)
                return "Error: username field is empty.";
            else // if (UserIsUnique(username)) *FEATURE NOT YET IMPLEMENTED
            {
                return username;
            }

        }

        private string InputPasswordValidation(string password)
        {
            char[] specialCharacters = {'!', '@', '#',
                                        '$', '%', '^',
                                        '&', '*', '_',
                                         '-', '+', '='};
            if (password == ""
                || password == null)
                return "Error: password field is empty.";
            else if (password.Length < 9)
                return "Error: password must be longer than 8 characters";
            else if (password.IndexOfAny(specialCharacters) == -1)
            { // method return -1 if none of those characters are in the string
                return "Error: password must contain at least one special character" +
                    " (ex: ! @ # $ % ^ & *)";
            }
            else
            {
                return password;
            }
        }

        // NOT YET IMPLEMENTED private bool UserIsUnique()

        /*     internal List<Order> OrderHistory
       {
           get { return OrderHistory; }
           set { 
           foreach (var newOrder in value)
               {
                   AddOrderToHistory(newOrder);
               }
           }

       }*/

        /* public User(string username, string password)
        {


        }*/

        /*internal void AddOrderToHistory(Order newOrder)
        {
            if (newOrder != null)
            {
                OrderHistory.Add(newOrder);
            }
        }*/


    }
}
