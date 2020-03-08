using System;

namespace harold_project0
{
    class Menu
    {
        static void DisplayMenu()
        {
            System.Console.WriteLine("Welcome to Backgammon pizza");
            System.Console.WriteLine("Type an option:");
            System.Console.WriteLine("1. New Order");
            System.Console.WriteLine("2. Check Order");
                // current pizza order, sign in
            System.Console.WriteLine("3. See Past Orders");
            System.Console.WriteLine("4. Nearest Location");
                // return one option or a list
                // Hardcoded for arlington?
            string input = Console.ReadLine();
            GuideInput(input);


        }

        static void GuideInput(string input)
        {
            input = ConvertInput(input);    // make input standardized to shorten conditional statements
        }

        static string ConvertInput(string input)
        {
            input = input.ToLower();    // so I do not need to think about
                                        // every different capitalization
                                        // NeW OrdER, NEW ORDER, New order...
            if (input == "1." || 
                input == "1" ||
                input == "new order")
                {
                    return input = "1"; // easier to remember if just use the number options
                }

            //if (input == "2." )

            else
            {
                return "invalid input";
            }
        }




    }
}
