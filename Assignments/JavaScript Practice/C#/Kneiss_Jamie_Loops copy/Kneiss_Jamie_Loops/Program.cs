using System;
using System.Threading;

namespace Kneiss_Jamie_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
        //Delay Output
            Thread.Sleep(250);
        //Set Divider
            Console.WriteLine("========================= ========================= =========================");
        //Delay Output
            Thread.Sleep(250);
        //User Promp: Name
            Console.WriteLine("Hey there, what's your name?");
            string nomenTuum = Console.ReadLine();
        //Validate
            while (string.IsNullOrWhiteSpace(nomenTuum))
            {
                Console.WriteLine("Your response is invalidd.");
            //User Prompt: Resubmit Response
                Console.WriteLine("Please resubmit your response.");
                nomenTuum = Console.ReadLine();
            }
        //User Prompt: Balance
            Console.WriteLine("How much is in that piggy bank of yours, " + nomenTuum + "?");
            string balanceString = Console.ReadLine();
        //Cast: To Decimal
            decimal balanceRaw;
        //Validate
            while (!decimal.TryParse(balanceString, out balanceRaw))
            {
                Console.WriteLine("Your response is either not a number or not in the right format.");
            //User Prompt: Resubmit Response
                Console.WriteLine("Please resubmit your response.");
                balanceString = Console.ReadLine();
            }
        //Round: To 2
            balanceRaw = (decimal)Math.Round(balanceRaw, 2);
        //User Prompt: Money Added
            Console.WriteLine("How much is added each month?");
            string addString = Console.ReadLine();
        //Cast: To Decimal
            decimal addRaw;
        //Validate
            while (!decimal.TryParse(addString, out addRaw))
            {
                Console.WriteLine("Your response is either not a number or not in the right format.");
            //User Prompt: Resubmit Response
                Console.WriteLine("Please resubmit your response.");
                addString = Console.ReadLine();
            }
        //Round: To 2
            addRaw = (decimal)Math.Round(addRaw, 2);
        //Create: Loop; For: 12 Months
            for (int monthNum = 1; monthNum <= 12; monthNum++)
            {
            //Delay Output
                Thread.Sleep(400);
            //Calculate: Total
                decimal totalBalance = balanceRaw += addRaw;
            //Roundd: To 2
                totalBalance = (decimal)Math.Round(totalBalance, 2);
            //Conditional: If: Month is 1, 2, or 12
                if (monthNum == 1 || monthNum == 2 || monthNum == 12)
                {
                //Conditional: If month is one, display text.
                    if (monthNum == 1)
                    {
                        Console.WriteLine("Your total for this month is $" + totalBalance + ".");
                    }
                //Conditional: If: Month is two, Display Text.
                    else if (monthNum == 2)
                    {
                        Console.WriteLine("Your total for next month will be $" + totalBalance + ".");
                    }
                //Conditional: If: Month is twelve: Display Text
                    else if (monthNum == 12)
                    {
                        Console.WriteLine("Your total after a year will be $" + totalBalance + ".");
                    }
                }
            //Conditional: Else: Display Text
                else
                {
                    Console.WriteLine("Your total for month " + monthNum + " will be $" + totalBalance + ".");
                }
            }

            /*Test 1
             * 
             * Hey there, what's your name?
             * sg
             * How much is in that piggy bank of yours, sg?
             * 23
             * How much is added each month?
             * 3
             * Your total for this month is $26.
             * Your total for next month will be $29.
             * Your total for month 3 will be $32.
             * Your total for month 4 will be $35.
             * Your total for month 5 will be $38.
             * Your total for month 6 will be $41.
             * Your total for month 7 will be $44.
             * Your total for month 8 will be $47.
             * Your total for month 9 will be $50.
             * Your total for month 10 will be $53.
             * Your total for month 11 will be $56.
             * Your total after a year will be $59.
             */

        //Delay Output
            Thread.Sleep(250);
        //Set Divider
            Console.WriteLine("========================= ========================= =========================");
        //Delay Output
            Thread.Sleep(250);
        //User Prompt: 
            Console.WriteLine("Hey, " + nomenTuum + ", what's the timer on the countdown, again?");
                string elNumero = Console.ReadLine();
        //Cast: To Int
            int theNum;
        //Validate
            while (!int.TryParse(elNumero, out theNum))
            {
                Console.WriteLine("Your response is either not formatted properly or not an integer.");
            //User Prompt: Resubmit Response
                Console.WriteLine("Please resubmit your response.");
                elNumero = Console.ReadLine();
            }
            Console.WriteLine("Blastoff in T-");
        //Loop: While Number > 0, Count Down
            while (theNum >= 0)
            {
            //Delay Output
                Thread.Sleep(500);
                Console.WriteLine(theNum);
                theNum--;
            }
            Console.WriteLine("BLASTOFF");

            /*
             * Hey, sg, what's the timer on the countdown, again?
             * 3
             * Blastoff in T-
             * 3
             * 2
             * 1
             * 0
             * BLASTOFF
             * ==========
             */

        //Delay Output
            Thread.Sleep(250);
        //Set Divider
            Console.WriteLine("========================= ========================= =========================");
        //Delay Output
            Thread.Sleep(250);
        //User Prompt: Remaining Donuts
            Console.WriteLine("What's up " + nomenTuum + ", how many donuts are left?");
            string remainderString = Console.ReadLine();
        //Cast: To Int
            int remainderRaw;
        //Validate
            while (!int.TryParse(remainderString, out remainderRaw) || (remainderRaw <= 0))
            {
            //Conditional: If: Not a Number
                if (!int.TryParse(remainderString, out remainderRaw))
                {
                //User Prompt: Remaining Donuts
                    Console.WriteLine("That's... not a number, or you're not spelling it right." + nomenTuum + ", how many are left, again?");
                }
            //Conditional: Else If: Below Zero
                else 
                {
                //User Prompt: Remaining Donuts
                    Console.WriteLine("Come on, " + nomenTuum + ", you're lying. How many are really left?");
                }
                remainderString = Console.ReadLine();
            }
        //User Prompt: WantedDonuts
            Console.WriteLine("Cool, how many do you want?");
            string wantsString = Console.ReadLine();
            int wantsRaw;
        //Validate
            while (!int.TryParse(wantsString, out wantsRaw) || wantsRaw > 3 || wantsRaw < 0)
            {
            //Conditional
                if (!int.TryParse(wantsString, out wantsRaw))
                {
                    Console.WriteLine("That's... not a number, or you're not writing it right." + nomenTuum + ", how many do you want?");
                }
            //Conditional: If Desired Donuts is > 3, Display Text
                else if (wantsRaw > 3)
                {
                //User Prompt: Resubmit Response
                    Console.WriteLine("Come on, " + nomenTuum + ", don't be a hog. Try less than 4?");
                }
            //Conditional: If Desired Donuts is < 0, Display Text
                else if (wantsRaw < 0)
                {
                //User Prompt: Resubmit Response
                    Console.WriteLine("That's... literally impossible, try again dude.");
                }
                wantsString = Console.ReadLine();
            }
        //Calculate: Remaining Donuts
            int finalDonuts = remainderRaw - wantsRaw;
        //Loop: While Remainder > 0, Prompt User
            while (finalDonuts > 0)
            {
                Console.WriteLine("Awesome, there are " + finalDonuts + " donuts left.");
            //User Prompt: Desired Donutss
                Console.WriteLine("Who wants more donuts?");
                string newNeeds = Console.ReadLine();
            //Cast: To INt
                int newWants;
            //Validate
                while (!int.TryParse(newNeeds, out newWants))
                {
                    Console.WriteLine("Your response is either not formatted properly or not an integer.");
                    Console.WriteLine("Please resubmit your response.");
                    newNeeds = Console.ReadLine();
                }
            //Calculate: New Remainder
                finalDonuts = finalDonuts - newWants;
            }
        //Conditional: If Remainder < 0, Display Text.
            if (finalDonuts <= 0)
            {
                if (finalDonuts < 0)
                {
                    int oweDonuts = finalDonuts * -2 / 2;
                    if (oweDonuts == 1)
                        Console.WriteLine("Okay so I'll owe you " + oweDonuts + " donut, then.");
                    else
                    {
                        Console.WriteLine("Okay so I'll owe you " + oweDonuts + " donut, then.");
                    }
                }
            //Conditional: If Remainder = 0, End Program
                else if (finalDonuts == 0)
                {
                    Console.WriteLine("Alright, that's the last of the donuts. Enjoy.");
                }
            
                /*
                 * What's up sg, how many donuts are left?
                 * 5
                 * Cool, how many do you want?
                 * 3
                 * Who wants more donuts?
                 * 2
                 * Awesome, there are -1 donuts left.
                 * Okay so I'll owe you 1 donuts, then.
                 */

            //End Program
            }
        }
    }
}
