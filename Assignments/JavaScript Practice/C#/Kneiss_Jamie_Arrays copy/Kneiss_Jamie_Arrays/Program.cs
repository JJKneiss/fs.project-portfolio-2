using System;

namespace Kneiss_Jamie_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        //Set Divider
            Console.WriteLine("========================= ========================= =========================");
        //Prompt User: Name
            Console.WriteLine("What's your name?");
                string nomenTuum = Console.ReadLine();
        //Validate
            while (string.IsNullOrWhiteSpace(nomenTuum))
            {
                Console.WriteLine("That's... not a real name, or you're not writing it right.");
            //User Prompt: Resubmit Name
                Console.WriteLine("What's your name, again?");
                nomenTuum = Console.ReadLine();
            }
        //Prompt User: Book Number
            Console.WriteLine("How many books?");
            string bookBuy = Console.ReadLine();
            int bookNum;
        //Validate
            while (!int.TryParse(bookBuy, out bookNum))
            {
                Console.WriteLine("That's... not a number, or you're not writing it right, " + nomenTuum +".");
            //User Prompt: Books Bought
                Console.WriteLine("How many books are you buying?");
                bookBuy = Console.ReadLine();
            }
        //Create: Array
            decimal[] bookArray = new decimal[bookNum];
        //Create Loop
            for (int i = 0; i < bookArray.Length; i++)
            {
            //Prompt User: Book Price
                Console.WriteLine("How much for this book?");
                string bookCost = Console.ReadLine();
            //Validate
                while (!decimal.TryParse(bookCost, out bookArray[i]))
                {
                    Console.WriteLine("That's... not a number, or you're not writing it right, " + nomenTuum + ".");
                    Console.WriteLine("How many books are you buying?");
                        bookCost = Console.ReadLine();
                }
            }
            decimal sum = 0;
        //Create Loop
            for (int i = 0; i < bookArray.Length; i++)
            {
                sum += bookArray[i];
            }
        //Round: To 2
            sum = (decimal)Math.Round(sum, 2);
        //Create Conditional
            if (bookNum == 0)
            {
                Console.WriteLine("Your total is $" + sum + " for " + bookArray.Length + " book.");
            }
            else
            {
                Console.WriteLine("Your total is $" + sum + " for " + bookArray.Length + " books.");
            }
        //Set Divider
            Console.WriteLine("========================= ========================= =========================");
        //Create Array
            string[] someThings = new string[6];
                someThings[0] = "monitor";
                someThings[1] = "computer";
                someThings[2] = "desk";
                someThings[3] = "keyboard";
                someThings[4] = "mouse";
                someThings[5] = "chair";
        //Create Array
            string[] someColors = new string[6];
                someColors[0] = "black";
                someColors[1] = "gray";
                someColors[2] = "brown";
                someColors[3] = "green";
                someColors[4] = "orange";
                someColors[5] = "blue";       
        //Create Loop
            for (int i = 0; i < someColors.Length; i++)
            {
                Console.WriteLine("The main color of the " + someThings[i] + " is " +someColors[i]+ ".");
            }
        }
    //End Program
    }
    //Test Values

    /*
     *========================= ========================= =========================
    What's your name?
    Jamie
    How many books?
    4
    How much for this book?
    3.532
    How much for this book?
    23.56
    How much for this book?
    2.2344
    How much for this book?
    5.43
    Your total is $34.76 for 4 books.
    ========================= ========================= =========================
    The main color of the monitor is black.
    The main color of the computer is gray.
    The main color of the desk is brown.
    The main color of the keyboard is green.
    The main color of the mouse is orange.
    The main color of the chair is blue.
     */

    /*
     
     */

}
