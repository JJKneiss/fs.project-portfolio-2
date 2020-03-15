using System;

namespace Kneiss_Jamie_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jamie Kneiss
             * July 12th, 2019
             * Prompting the User
             * 
             */

            //To get User input into our program, use Console.ReadddLine() - reads the next in in the console AND returns it as aa texts tring when the User hits enter.
            //Ask the User a question.

            Console.WriteLine("Pease enter your name.");
            //Catch the Users response.
            //Create a variable to HOLD the Users response.

            string uNombre = Console.ReadLine();

            //Use the User's name in a WriteLine.
            //Say hello to the User.

            Console.WriteLine("Hello " + uNombre + "! Let's play a game of MadLibs, how's that sound?");
                Console.WriteLine("(you don't have a choice here :3.)")
;            //Prompt the User for a number.

            Console.WriteLine("I'll need and adjective, whatever that is @_@.");
                string nani0w0 = Console.ReadLine();

            Console.WriteLine("\r\nPlease give me a type of animal!");
                string goodBoi = Console.ReadLine();
                    Console.WriteLine("Awh, I love " + goodBoi + "s. Now a name, just not your own.");
                        string elNombre = Console.ReadLine();
                            Console.WriteLine("Yeah, " + elNombre + " is as good a name as any.");

            Console.WriteLine("How about a food?");
                Console.WriteLine("(Isn't this so fun?!(don't answer that...)");
                    string kurgerBing = Console.ReadLine();
                        Console.WriteLine("You like " + kurgerBing + "? I thought you were better than that, " + uNombre + ".");
            Console.WriteLine("Now let's spice things up! Drop me 3 integers. A cost, a year, and the third can be a random number.");
                string costCo = Console.ReadLine();
                    string yearOne = Console.ReadLine();
                        string randoNum = Console.ReadLine();
                            int walMart = int.Parse(costCo);
                                int notYearOne = int.Parse(yearOne);
                                    int certainNum = int.Parse(randoNum);
            /*
             * Prompt the User for a number.
             * Console.WriteLine("\r\nPlease type in an integer.");
             * Catch the User's response.
             *Create a variable to holdd the response.
             *string userNumberString = Console.ReadLine();

            //Convert the text string into a number data type
            //In this case - integers - int
            //Convert the string to an int - using Parse
            // dataType.Parse)variable to convert)
            //Create a variable to hol dthis converted value.

            int userNumber = int.Parse(userNumberString);

            //Multioply the User number times 2 and give it to the User.
            //Do not od math inside of WriteLine
            //Console.WriteLine(userNumber*2);
            userNumber *= 2;

            //Output to the user
            Console.WriteLine(userName+ ", your number times 2 is " + userNumber);

             */


            Console.WriteLine("Ohhh boy... well this is... a story?");
                Console.WriteLine("");
                    Console.WriteLine("One day, in the year "+notYearOne+" a "+nani0w0+" " + goodBoi + " ran around Winter Park, coming across a biker named " + elNombre + ". The "+nani0w0+" " + goodBoi + " began to sit next to the tired "+elNombre+", but was soon chased off, as "+elNombre+" was allergic to "+goodBoi+"s. Throwing his $"+walMart+" bag of "+kurgerBing+" at the "+goodBoi+" he soon realized he lost "+certainNum+ " of his "+kurgerBing+". Saddened by this, he quietly sat contemplating the state of things.");

        }
    }
}
