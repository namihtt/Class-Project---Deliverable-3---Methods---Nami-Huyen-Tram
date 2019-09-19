using System;

namespace Class_Project___Deliverable_3___Methods___Nami_Huyen_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("What is your name? Please type it here: ");
                talk();
                void talk()
                {
                    string userName = Console.ReadLine();
                    Console.WriteLine("Hello " + userName + "!");
                    Console.WriteLine("Do you want to eat here or take out today?");
                    Console.Write("Please type either 'eat here' or 'take out': ");
                    string userAns = Console.ReadLine();
                    if (userAns == "eat here")
                    {
                        Console.WriteLine("Please have a seat wherever you would like!");
                        Console.WriteLine("One of our staffs will be with you shortly!");
                    }
                    else if (userAns == "take out")
                    {
                        Console.WriteLine("Please take a look at our menu and be ready to place your order!");
                        displayMenu();
                    }
                    else
                    {
                        Console.WriteLine("Please wait a few minutes and one of our staffs will be with you!");
                    }
                    Console.WriteLine("You can press any key to exit the program now.");
                    Console.ReadKey(true);
                }
                void displayMenu ()
                {
                    Console.WriteLine("Grilled Chicken Sandwich__ $7.00");
                    Console.WriteLine("Grilled Pork Sandwich_____ $7.50");
                    Console.WriteLine("Grilled Beef Sandwich_____ $8.00");
                    Console.WriteLine("Fried Tofu Sandwich_______ $7.00");
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
