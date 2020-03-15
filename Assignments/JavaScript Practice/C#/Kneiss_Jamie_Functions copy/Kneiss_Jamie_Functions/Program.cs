using System;
using System.Threading;

namespace Kneiss_Jamie_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jamie Kneiss
            //7-24-19
            //Functions

            Console.WriteLine("Welcome to the Currency Converter. How many Euros would you like to convert?");
            string euroString = Console.ReadLine();
            decimal euroRaw;
            while (!decimal.TryParse(euroString, out euroRaw))
            {
                Console.WriteLine("Your response is not a number.");
                Console.WriteLine("Please resubmit your response.");
                euroString = Console.ReadLine();
            }
            decimal euroNum = (decimal)Math.Round(euroRaw, 2);
            Console.WriteLine("You'd like to convert " + euroNum + " Euros to US dollars, alright.");
            decimal convertMon = CurrencyConverter(euroNum);
            Console.WriteLine("Your total is $" + convertMon + ".");
            /*
             * Test 1
             *
             * You'd like to convert 43.56 Euros to US dollars, alright.
             * Converting.
             * Done.
             * Your total is $50.53.
             * 
             */

            Console.WriteLine("========================= ========================= =========================");

            Console.WriteLine("How much do you weigh, in pounds? \r\nSorry, too soon?");
                string userString = Console.ReadLine();
                    decimal userRaw;
            while (!decimal.TryParse(userString, out userRaw))
            {
                Console.WriteLine("Your response is not a number.");
                Console.WriteLine("Please resubmit your response.");
                userString = Console.ReadLine();
            }
            decimal userEarth = (decimal)Math.Round(userRaw, 2);
            Console.WriteLine("On Earth, you weigh " + userEarth + " pounds.");
                Console.WriteLine("Let's see how much that is elsewhere in the solar system.");
                    Console.WriteLine("Please input the number of one of the following planets");
                        Console.WriteLine("1. Mercury \n2. Venus \n3. Earth \n4. Mars \n5. Jupiter \n6. Saturn \n7. Uranus \n8. Neptune");
                            string planetString = Console.ReadLine();
                                int planetNum;
            while (!int.TryParse(planetString, out planetNum))
            {
                Console.WriteLine("Your response is not a number.");
                Console.WriteLine("Please resubmit your response.");
                planetString = Console.ReadLine();
            }
            if (planetNum == 3)
            {
                Console.WriteLine("Not exactly daring, are we?");
                Console.WriteLine("Your weight remains " + userEarth + ".");
            }
            else if (planetNum == 1 || planetNum == 4)
            {
                decimal planetGrav = .38m;
                decimal totalWeight = Astronomical(userEarth, planetGrav);
                if (planetNum == 1)
                {
                    Console.WriteLine("Your weight on Mercury would be " + totalWeight + " pounds.");
                }
                if (planetNum == 4)
                {
                    Console.WriteLine("Your weight on Mars would be " + totalWeight + " pounds.");
                }
            }
            else if (planetNum == 2)
            {
                decimal planetGrav = .91m;
                decimal totalWeight = Astronomical(userEarth, planetGrav);
                Console.WriteLine("Your weight on Venus would be "+totalWeight+" pounds.");
            }
            else if (planetNum == 5)
            {
                decimal planetGrav = 2.34m;
                decimal totalWeight = Astronomical (userEarth, planetGrav);
                Console.WriteLine("Your weight on Jupiter would be " + totalWeight + " pounds.");
            }
            else if (planetNum == 6)
                {
                    decimal planetGrav = .93m;
                    decimal totalWeight = Astronomical(userEarth, planetGrav);
                    Console.WriteLine("Your weight on Saturn would be " + totalWeight + " pounds.");
                }
            else if (planetNum == 7)
                {
                decimal planetGrav = .92m;
                    decimal totalWeight = Astronomical(userEarth, planetGrav);
                Console.WriteLine("Your weight on Uranus would be " + totalWeight + " pounds.");
                }
            else if (planetNum == 8)
                {
                decimal planetGrav = 1.12m;
                    decimal totalWeight = Astronomical(userEarth, planetGrav);
                Console.WriteLine("Your weight on Neptune would be " + totalWeight + " pounds.");
                }
            /*
             * Test 2
             * 
             * How much do you weigh, in pounds?
             * Sorry, too soon?
             * 127.67
             * On Earth, you weigh 127.67 pounds.
             * Let's see how much that is elsewhere in the solar system.
             * Please input the number of one of the following planets
             * 1. Mercury
             * 2. Venus
             * 3. Earth
             * 4. Mars
             * 5. Jupiter
             * 6. Saturn
             * 7. Uranus
             * 8. Neptune
             * 6
             * Your weight on Saturn would be 118.73 pounds.
             */

            Console.WriteLine("========================= ========================= =========================");

            decimal[] someDiscounts = new decimal[6];
            someDiscounts[0] = .05m;
            someDiscounts[1] = .10m;
            someDiscounts[2] = .15m;
            someDiscounts[3] = .20m;
            someDiscounts[4] = .25m;
            someDiscounts[5] = .30m;
            string[] stringDiscounts = new string[6];
            stringDiscounts[0] = "five percent";
            stringDiscounts[1] = "ten percent";
            stringDiscounts[2] = "fifteen percent";
            stringDiscounts[3] = "twenty percent";
            stringDiscounts[4] = "twenty-five percent";
            stringDiscounts[5] = "thirty percent";

            Console.WriteLine("What is the price of that item?");
            string userString2 = Console.ReadLine();
            decimal userRaw2;

            while (!decimal.TryParse(userString2, out userRaw2))
                {
                    Console.WriteLine("Your response is not a number.");
                        Console.WriteLine("Please resubmit your response.");
                            userString2 = Console.ReadLine();
                }
            decimal userNum2 = (decimal)Math.Round(userRaw2, 2);
            for (int i = 0; i < 6; i++)
            {
                decimal finalNum = DiscountCalc(userNum2, someDiscounts[i]);
                Console.WriteLine("Your discounted price at" +stringDiscounts[i]+" is $"+finalNum+".");
            }
            /*
             * Test 3
             * 
             * What is the price of that item?
             * 3.535
             * Your discounted price atfive percent is $3.36.
             * Your discounted price atten percent is $3.19.
             * Your discounted price atfifteen percent is $3.01.
             * Your discounted price attwenty percent is $2.83.
             * Your discounted price attwenty-five percent is $2.66.
             * Your discounted price atthirty percent is $2.48.
             */

            Console.WriteLine("========================= ========================= =========================");
        }
            public static decimal CurrencyConverter(decimal euroMath)
            {
                decimal usMath = (decimal)(euroMath * 1.16m);
                    decimal usNum = (decimal)Math.Round(usMath, 2);
                Thread.Sleep(200);
                    Console.WriteLine("Converting.");
                        Thread.Sleep(200);
                            Console.WriteLine("Done.");
                return usNum;
            }
            
            public static decimal Astronomical(decimal planetMaths, decimal userWeight)
                {
                    decimal finalWeight = planetMaths * userWeight;
                        decimal totalWeight = (decimal)Math.Round(finalWeight, 2);
                            return totalWeight;
                }
            public static decimal DiscountCalc(decimal userMath, decimal discountsMath)
            {
                decimal calcMath = userMath * discountsMath;
            decimal nextNum = userMath - calcMath;
                decimal finalNum = (decimal)Math.Round(nextNum, 2);
                return finalNum;
            }
    }
}
