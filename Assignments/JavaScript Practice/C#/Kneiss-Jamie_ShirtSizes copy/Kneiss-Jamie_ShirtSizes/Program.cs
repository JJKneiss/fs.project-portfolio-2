using System;

namespace Kneiss_Jamie_ShirtSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jamie Kneiss
             * 7-29-19
             * Shirt Sizes
             */
            Console.WriteLine("Hello! Welcome to Shirts R Us! What is your shirt size");

            string userAnswer = Console.ReadLine();

            Validation(userAnswer);
            ArrayHolder();

            Console.WriteLine("Thank you for visitng us at Shirts R Us!");    
        }

        public static void ArrayHolder()
        {
            string[] shirtArray = { "XX-Large", "Medium", "Large", "Small", "XX-Large", "Small", "Large", "XX-Large", "Large", "X-Large", "Medium", "Medium" };
            int smallShirt = 0;
            int mediumShirt = 0;
            int largeShirt = 0;
            int xLargeShirt = 0;
            int xxLargeShirt = 0;
            for (int i = 0; i < shirtArray.Length; i++)
            {
                if (shirtArray[i] == "Small")
                {
                    smallShirt++;
                }
                else if (shirtArray[i] == "Medium")
                {
                    mediumShirt++;
                }
                else if (shirtArray[i] == "Large")
                {
                    largeShirt++;
                }
                else if (shirtArray[i] == "X-Large")
                {
                    xLargeShirt++;
                }
                else if (shirtArray[i] == "XX-Large")
                {
                    xxLargeShirt++;
                }
            }
            Conditionals(smallShirt, mediumShirt, largeShirt, xLargeShirt, xxLargeShirt);
        }

        public static string Validation(string userShirt)
        {
                    while (string.IsNullOrWhiteSpace(userShirt) || userShirt.ToLower() != "Small")
                    {
                        Console.WriteLine("That doesn't seem to be a shirt size, try again.");
                        userShirt = Console.ReadLine();
                    }
            return userShirt;
        }

        public static int Conditionals(int smallInt, int medInt, int larInt, int xLarInt, int xxLarInt)
        {
            if (smallInt== 1)
            {
                Console.WriteLine("Your total order will consist of {0} small shirt.", smallInt);
            }
            else if (smallInt > 1)
            {
                Console.WriteLine("Your total order will consist of {0} small shirts.", smallInt);
            }
            if (medInt == 1)
            {
                Console.WriteLine("Your total order will consist of {0} medium shirt.", medInt);
            }
            else if (medInt > 1)
            {
                Console.WriteLine("Your total order will consist of {0} medium shirts.", medInt);
            }
            if (larInt == 1)
            {
                Console.WriteLine("Your total order will consist of {0} large shirt.", larInt);
            }
            else if (larInt > 1)
            {
                Console.WriteLine("Your total order will consist of {0} large shirts.", larInt);
            }
            if (xLarInt == 1)
            {
                Console.WriteLine("Your total order will consist of {0} x-large shirt.", xLarInt);
            }
            else if (xLarInt > 1)
            {
                Console.WriteLine("Your total order will consist of {0} x-large shirts.", xLarInt);
            }
            if (xxLarInt == 1)
            {
                Console.WriteLine("Your total order will consist of {0} xx-large shirt.", xxLarInt);
            }
            else if (xxLarInt > 1)
            {
                Console.WriteLine("Your total order will consist of {0} xx-large shirts.", xxLarInt);
            }

            return (smallInt + medInt + larInt + xLarInt + xxLarInt);
        }
    }
}
