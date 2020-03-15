using System;
using System.Collections.Generic;

namespace Kneiss_Jamie_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jamie Kneiss
             * 7-26-19
             * Lists
             */

            //Trying to keep better track of both what I *am* doing and what I *should* be doing. Using Comments. Will format further if necessary.

            //Introduction
                Console.WriteLine("Hello there, welcome to to the Code Travel Agency!");
                    Console.WriteLine("The following program will keep a log of your planned trips.");
            //Create List.
                List<string> locations = new List<string>();
                //Start Empty.
            //Prompt User: Location.
                Console.WriteLine("Where would you like to go first?");
                    string locationOne = Console.ReadLine();
            //Validate
                while(string.IsNullOrWhiteSpace(locationOne))
                {
                    Console.WriteLine("Invalid Input. Please Resubmit Your Response.");
                        Console.ReadLine();
                }
            //Add Value.
                locations.Add(locationOne);
            //Prompt User: 'Yes' or 'No', Addditional Locations.
                Console.WriteLine("Would you like to add another location?");
                    string siNo = Console.ReadLine();
            //Validate
                while (string.IsNullOrWhiteSpace(siNo) || (siNo.ToLower() != "yes" && siNo.ToLower() != "no"))
                {
                    Console.WriteLine("Invalid Input. Please Resubmit Your Response.");
                        siNo = Console.ReadLine();
                }
            //Create Loop: Addditional Locations.
                while (siNo.ToLower() == "yes")
                {
                //Prompt User: Location.
                    Console.WriteLine("Wonderful, where would you like to travel?");
                        string locationAdd = Console.ReadLine();
                            locations.Add(locationAdd);
                    Console.WriteLine("Would you like to add another location?");
                        siNo = Console.ReadLine();
                //Validate.
                    while (string.IsNullOrWhiteSpace(siNo) || (siNo.ToLower() != "yes" && siNo.ToLower() != "no"))
                    {
                        Console.WriteLine("Invalid Input. Please Resubmit Your Response.");
                            siNo = Console.ReadLine();
                    }
                //If "No": End Loop.
                    if (siNo.ToLower() == "no")
                    {
                        Console.WriteLine("Your trips have been logged!");
                    }
                }
            //If "No": Continue.
                if (siNo == "No" || siNo == "no")
                {
                    Console.WriteLine("Enjoy your travels!");
                }
            //Call Function
                TripOutput(locations); 
        }
    //Create Function
        public static void TripOutput(List<string> destinations)
        {
        //Output: Destination Number
            if (destinations.Count == 1)
            {
                Console.WriteLine("You will take {0} trip, this year.", destinations.Count);
            }
            else
            {
                Console.WriteLine("You will take {0} trips, this year.", destinations.Count);
            }
        //Create: Loop
            //Output: Visited Locations
            for (int i = 0; i < destinations.Count; i++)
            {
                Console.WriteLine("You will visit beautiful {0}, this year.", destinations[i]);
            }
        //Output: Thank User.
            Console.WriteLine("Thank you for using the Code Travel Agency. Have a great day!");
        }
    //End Program
    }
    /*
     * Test Values
     *
     * Hello there, welcome to to the Code Travel Agency!
     * The following program will keep a log of your planned trips.
     * Where would you like to go first?
     * N.Y.C.
     * Would you like to add another location?
     * gfd
     * Invalid Input. Please Resubmit Your Response.
     * Yes
     * Wonderful, where would you like to travel?
     * California
     * Would you like to add another location?
     * no
     * Your trips have been logged!
     * Enjoy your travels!
     * You will take 2 trips, this year.
     * You will visit beautiful N.Y.C., this year.
     * You will visit beautiful California, this year.
     * Thank you for using the Code Travel Agency. Have a great day!
     */
}