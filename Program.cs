/* Programmer: Nami Huyen Tram
 * Date: 9/19/2019
 * Comments: Class Project - Deliverable 3 - Methods
 */

using System;

namespace Class_Project___Deliverable_3___Methods___Nami_Huyen_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch to prevent crashing the program
            try
            {
                // declare variables and prices so we can fix this easier later if market price change
                decimal fixedCost = 5;
                decimal chickenPrice = 2;
                decimal porkPrice = 2;
                decimal beefPrice = 3;
                decimal tofuPrice = 2;
                decimal ckBM;
                decimal pkBM;
                decimal bfBM;
                decimal tfBM;
                // ask user's name
                Console.Write("What is your name? Please type it here: ");
                // call custom method
                talk();
                // custom method
                void talk()
                {
                    // read user input
                    string userName = Console.ReadLine();
                    // responde to user input and ask for more input
                    Console.WriteLine("Hello " + userName + "!");
                    Console.WriteLine("Do you want to eat here or take out today?");
                    Console.Write("Please type either 'eat here' or 'take out': ");
                    // read user input
                    string userAns = Console.ReadLine();
                    // if else statement to responde accordingly to user input
                    if (userAns == "eat here")
                    {
                        Console.WriteLine("Please have a seat wherever you would like!");
                        Console.WriteLine("One of our staffs will be with you shortly!");
                    }
                    else if (userAns == "take out")
                    {
                        Console.WriteLine("Please take a look at our menu and be ready to place your order!");
                        // call custom method to display menu
                        displayMenu();
                    }
                    else
                    {
                        Console.WriteLine("Please wait a few minutes and one of our staffs will be with you!");
                    }
                    Console.WriteLine("You can press any key to exit the program now.");
                    Console.ReadKey(true);
                } // end of custom method
                // custom method to display menu
                void displayMenu ()
                {
                    // calculating sandwich prices
                    ckBM = fixedCost + chickenPrice;
                    pkBM = fixedCost + porkPrice;
                    bfBM = fixedCost + beefPrice;
                    tfBM = fixedCost + tofuPrice;
                    // display menu
                    Console.WriteLine("Grilled Chicken Sandwich__ $" + ckBM);
                    Console.WriteLine("Grilled Pork Sandwich_____ $" + pkBM);
                    Console.WriteLine("Grilled Beef Sandwich_____ $" + bfBM);
                    Console.WriteLine("Fried Tofu Sandwich_______ $" + tfBM);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Your input was invalid! " +
                    "Please press any key to exit the program and try again.");
                Console.ReadKey(true);
            } // End of catch
        }
    }
}
