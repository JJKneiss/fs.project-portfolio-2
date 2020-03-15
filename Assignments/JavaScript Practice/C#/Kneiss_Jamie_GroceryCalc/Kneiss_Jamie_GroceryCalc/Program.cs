using System;

namespace Kneiss_Jamie_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, what's your name?");
                string nomenTuum = Console.ReadLine();
                //nomenTuum simply means 'Your Name' in Latin. Shocker, right?
            Console.WriteLine("Cool, nice to meet you "+nomenTuum+". I'm Rob. \r\nSo, I have a list of groceries and I just need help with pricing. \r\nDon't laugh, robots eat too, you know. :3 (So insensitive...)");
                Console.WriteLine("Mind giving me the cost of a banana at WalMart?");
                    string thatsNanas = Console.ReadLine();
                Console.WriteLine("Now how about a beef brisket?");
                    string wheresTheBeef = Console.ReadLine();
                Console.WriteLine("Awesome, now how about an apple pie? I love warm apple pie. ^-^");
                    string apps2Apps = Console.ReadLine();
            Console.WriteLine("Thanks so much!");
                float arbysHasIt = float.Parse(wheresTheBeef);
                    arbysHasIt = (float)Math.Round(arbysHasIt, 2);
                float stillNanas = float.Parse(thatsNanas);
                    stillNanas = (float)Math.Round(stillNanas, 2);
                float apps2Oranges = float.Parse(apps2Apps);
                    apps2Oranges = (float)Math.Round(apps2Oranges, 2);
            Console.WriteLine("Hm... how many bananas should I get?");
                string moreNanas = Console.ReadLine();
                    float nanas4All = float.Parse(moreNanas);
                    float totsNanas = stillNanas * nanas4All;
            Console.WriteLine("What about the beef brisket??");
                string beefIsGood = Console.ReadLine();
                    float beef4All = float.Parse(beefIsGood);
            float totsBeef = arbysHasIt * beef4All;
            Console.WriteLine("Now the apple pie? Please... I love apple pie. @_@");
                string apps2Avocados = Console.ReadLine();
                    float apps4All = float.Parse(apps2Avocados);
                    float totsApps = apps2Oranges * apps4All;
            Console.WriteLine("What's the sales tax around here?");
                string thisIsTaxing = Console.ReadLine();
                    float muchTaxingSoWow = float.Parse(thisIsTaxing);
                    float taxes4Dayz = muchTaxingSoWow /= 100;
                        float taxNanas = totsNanas * taxes4Dayz;
                            float finalNans = taxNanas + totsNanas;
                                finalNans = (float)Math.Round(finalNans, 2);
                        float taxBeef = totsBeef * taxes4Dayz;
                            float finalBeef = taxBeef + totsBeef;
                                finalBeef = (float)Math.Round(finalBeef, 2);
                        float taxApps = totsApps * taxes4Dayz;
                            float finalApps = taxApps + totsApps;
                                finalApps = (float)Math.Round(finalApps, 2);
                            float total = totsNanas + totsBeef + totsApps;
                            float totalTax = taxApps + taxBeef + taxNanas;
                                totalTax = (float)Math.Round(totalTax, 2);
                            float totalGrand = total + totalTax;


            Console.WriteLine("So, prior to tax, bananas would be $"+ totsNanas +", beef brisket would be $"+ totsBeef +" and apple pie would be $"+totsApps+". That all totals out to $" +total+". Glad I grabbed my paycheck...");
            Console.WriteLine("Oh, I almost forgot about sales tax... So, with tax. Bananas: " + finalNans + ". Beef brisket: " + finalBeef + ". Apple pie: " + finalApps + ". That sums $"+totalTax+" in taxes. Coming to a grand total of " + totalGrand + ". Great...");

            /*
             *Test 1
             *Banana P: $0.40
             *Beef P: $20.25
             *Apple P: $9.75
             *
             *Banana Q:4
             *Beef Q:2
             *Apple Q:3
             *
             * Sales Tax: 5%
             *
             * Results:  All Checks Out.
             *
             *
             * Test 2
             *Banana P: $0.75
             *Beef P: $13.24
             *Apple P: $3.75
             *
             *Banana Q:6
             *Beef Q:4
             *Apple Q:2
             *
             * Sales Tax: 9%
             *
             * Results: All Checks Out.
             * 
             */

            /*
             * It wasn't until roughly the last minute that I looked at my code and realized how much more compact and efficient I could've made it.
             * So many unnecessary variables and operations. i.e.
             * With totalGrand I could've summed total and totalTax, rather than having a whole set of separate variables added up in the way they were.
             * I don't really have the time to fix all of it, but I consolidated what I could in the time I had left.
             */
        }
    }
}
