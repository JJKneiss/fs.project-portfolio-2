using System;

namespace Kneiss_Jamie_CookieCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jamie Kneiss
            //Section 00, Term
            //SDI 19/07
            //Cookie Counter

        //Program Intro
            Console.WriteLine("Welcome to Cookie Counter! \r\nToday we'll calculate profit made in buying packaged cookies, then selling them indivually.");
        //User Prompt: Cookie Types
            Console.WriteLine("First off, what types of cookies will you be buying? \r\nPlease separate each type with a comma.");
                string cookiesRaw = Console.ReadLine();
        //Validate
            while (string.IsNullOrWhiteSpace(cookiesRaw))
            {
                Console.WriteLine("Your response is invalid.");
            //User Prompt: Cookie Types
                Console.WriteLine("Please resubmit your answer.");
                cookiesRaw = Console.ReadLine();
            }
        //Split: Array; Cookie Types.
            string[] cookieArray = cookiesRaw.Split(",");
            for (int i= 0; i < cookieArray.Length; i++)
            {
                cookieArray[i] = cookieArray[i].Trim();
            }
        //Create: Function Call
            decimal[] cookieCall = PromptCookieCosts(cookieArray);
        //User Prompt: Cookie Number
            Console.WriteLine("How many cookies are in each package?");
            string packageString = Console.ReadLine();
        //Cast To: Int
            int packageNum;
        //Validate
            while (!int.TryParse(packageString, out packageNum))
            {
                Console.WriteLine("Your response is not a price.");
                Console.WriteLine("Please resubmit your answer.");
                packageString = Console.ReadLine();
            }
        //Find: Total Cookies
            int total = packageNum * cookieArray.Length;
        //User Prompt: Individual Cost
            Console.WriteLine("What will you sell a single cookie for?");
            string unitString = Console.ReadLine();
        //Cast To: Decimal
            decimal unitCost;
        //Validate
            while (!decimal.TryParse(unitString, out unitCost))
            {
                Console.WriteLine("Your response is not a price.");
            //User Promp: Individual Cost
                Console.WriteLine("Please resubmit your answer.");
                unitString = Console.ReadLine();
            }
        //Round: To 2
            decimal.Round(unitCost, 2);
        //Create: Function Call
            decimal totalCall = TotalCookieCost(cookieCall);
        //Create: Function Call
            decimal amountCall = AmountSoldFor(cookieCall, unitCost, packageNum);
        //Find: Total Profit
            decimal totalProfit = amountCall - totalCall;
        //Round: To 2
            totalProfit = decimal.Round(totalProfit, 2);
        //Output: Final Answer
            Console.WriteLine("You will make $"+totalProfit+", if you sell all "+cookieArray.Length+" cookie types, asssuming each package of cookies contains "+total+" pieces for $"+unitCost+" per cookie.");
        }
    //Create: Function
        public static decimal[] PromptCookieCosts(string[]cookieTypes)
        {
        //Create: Array; Cookie Prices
            decimal[] cookiePrice = new decimal[cookieTypes.Length];    
        //Create: Loop: Cookie Prices: User Input
            for (int i = 0; i<cookieTypes.Length; i++)
            {
            //User Prompt: Cookie Cost
                Console.WriteLine("What is the cost of the {0}.",cookieTypes[i]);
                    string cookieString = Console.ReadLine();
            //Cast To: Decimal
                decimal cookieCost;
            //Validate
                while (!decimal.TryParse(cookieString, out cookieCost))
                    {
                        Console.WriteLine("Your response is not a price.");
                        Console.WriteLine("Please resubmit your answer.");
                        cookieString= Console.ReadLine();
                    }
            //Add: To Array
                cookiePrice[i] = cookieCost;
            }
        //Return: To Main
            return cookiePrice;
        }
    //Create: Function
        public static decimal TotalCookieCost(decimal[]cookiesMoar)
        {
            decimal cookieFinal = 0;
        //Create: Loop
            for (int i = 0; i < cookiesMoar.Length; i++)
            {
            //Calculate: Sum Packagages
                cookieFinal = cookiesMoar[i] + cookieFinal;
            }
        //Return: To Main
            return cookieFinal;
        }
    //Create Function
        public static decimal AmountSoldFor (decimal[] cookieCall, decimal unitPrice, int packageTotal)
        {
        //Calculate: Total Cookies
            int totalCookies = cookieCall.Length * packageTotal;
        //Calculate: Total Price
            decimal totalPrice = totalCookies * unitPrice;
        //Return: To Main
            return totalPrice;
        }
    //END PROGRAM
    }
    //TESTS
    //Test 1
    /*
     * Welcome to Cookie Counter!
     * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
     * First off, what types of cookies will you be buying?
     * Please separate each type with a comma.
     * Double Chocolate, Sugar, Snicker Doodle
     * What is the cost of cookie Double Chocolate.
     * 7.00
     * What is the cost of cookie Sugar.
     * 2.50
     * What is the cost of cookie Snicker Doodle.
     * 6.50
     * How many cookies are in each package?
     * 10
     * What will you sell a single cookie for?
     * 1
     * You will make $14.00, if you sell all 3 cookie types, asssuming each package of cookies contains 30 pieces for $1 per cookie.
     */
    //Test 2
    /*
     * Welcome to Cookie Counter!
     * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
     * First off, what types of cookies will you be buying?
     * Please separate each type with a comma.
     * Mint, Double Bubble  , Mystery
     * What is the cost of cookie Mint.
     * 3.34567
     * What is the cost of cookie Double Bubble.
     * 2.2345
     * What is the cost of cookie Mystery.
     * 5.43
     * How many cookies are in each package?
     * 5
     * What will you sell a single cookie for?
     * 1
     * You will make $3.99, if you sell all 3 cookie types, asssuming each package of cookies contains 15 pieces for $1 per cookie.
     */
    //Test 3
    /*
     * Welcome to Cookie Counter!
     * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
     * First off, what types of cookies will you be buying?
     * Please separate each type with a comma.
     * ddas , sfadf  , adfad dsdf , adadf
     * What is the cost of the ddas.
     * 345.32234
     * What is the cost of the sfadf.
     * 6.43345678
     * What is the cost of the adfad dsdf.
     * 234567.8765432
     * What is the cost of the adadf.
     * 3.222
     * How many cookies are in each package?
     * 56
     * What will you sell a single cookie for?
     * 1223
     * You will make $39029.15, if you sell all 4 cookie types, asssuming each package of cookies contains 224 pieces for $1223 per cookie.
     */

}
