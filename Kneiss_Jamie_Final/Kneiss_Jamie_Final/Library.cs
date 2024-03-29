﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Library
{
    public class Menu
    {
        public string Title { get; set; }
        public string Divider { get; set; }
        private List<string> _items;

        // Accept Array of Values
        public Menu(params string[] items)
        {
            // Set Title & Divider
            Title = "Main Menu";
            Divider = "===========================";
            // Create List
            _items = new List<string>();
            // Turn Array Items to List Format
            _items = items.ToList();
        }
        public void Formatting()
        {
            Utility.ChangeCyan(Title+"\r\n");
            Console.WriteLine(Divider);
        }
        // Set New Title According to Input
        public void NewTitle(string newTitle)
        {
            Title = newTitle;
            Formatting();
        }
        // Display Items Without Formatting & Title
        public void MinDisplay()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]: {_items[i]}");
            }
        }
        // Display Items With Formatting & Title
        public void MaxDisplay()
        {
            Formatting();
            MinDisplay();
        }
    }
    public class Validation
    {
        // Prompt Resubmission
        public static void Resubmit(string s)
        {
            Utility.Feedback($"{s}. Press enter to continue.", 1);
            Console.ReadKey();
        }
        // Validate 1 or More Integer Values
        public static int ValidateInt(string s, int x)
        {
            Utility.ChangeCyan("\n" + s + "\n");
            string response = Console.ReadLine();
            int i;
            while (!int.TryParse(response, out i))
            {
                if (x != 1)
                {
                    Resubmit("Please enter a valid integer");
                    Utility.ClearAtLine(0, 1);
                    Utility.ChangeCyan(s);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
                else
                {
                    Resubmit("Please enter a valid integer");
                    response = Console.ReadLine();
                }
            }
            return i;
        }
        // Validate 1 or More String Values
        public static string ValidateString(string s, int i)
        {
            Utility.ChangeCyan(s);
            string response = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(response))
            {
                if (i != 1)
                {
                    Resubmit("Do not leave this empty");
                    Utility.ClearAtLine(0, 1);
                    Utility.ChangeCyan(s);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
                else
                {
                    Resubmit("Do not leave this empty");
                    Utility.ClearAtLine(0, 1);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
            }
            return response;
        }
        public static decimal ValidateDecimal(string s, int i)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            decimal d;
            while (!decimal.TryParse(response, out d) || decimal.Parse(response) < 0)
            {
                if (i != 1)
                {
                    Resubmit("Please enter a valid decimal");
                    Utility.ClearAtLine(0, 1);
                    Utility.ChangeCyan(s);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
                else
                {
                    Resubmit("Do not leave this empty");
                    Utility.ClearAtLine(0, 1);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
            }
            return d;
        }
        public static double ValidateDouble(string s, int x)
        {
            Console.WriteLine();
            string response = Console.ReadLine();
            double d;
            while (!double.TryParse(response, out d))
            {
                if (x > 1)
                {
                    Resubmit("Please enter a valid decimal");
                    Utility.ClearAtLine(0, 1);
                    Utility.ChangeCyan(s);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
                else
                {
                    Resubmit("Do not leave this empty");
                    response = Console.ReadLine();
                }
            }
            return d;
        }
        public static float ValidateFloat(string s, int x)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            float f;
            while (!float.TryParse(response, out f) || float.Parse(response) < 0)
            {
                if (x > 1)
                {
                    Resubmit("Please enter a valid decimal");
                    Utility.ClearAtLine(0, 1);
                    Utility.ChangeCyan(s);
                    response = Console.ReadLine();
                    Utility.ClearAtLine(0, 1);
                }
                else
                {
                    Resubmit("Do not leave this empty");
                    response = Console.ReadLine();
                }
            }
            return f;
        }
    }
    public class Utility
    {
        // Prompt Input to Continue
        public static void Continue(string s)
        {
            Console.WriteLine(s);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Welcome(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Goodbye(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg);
        }
        // Set Color According to Number Input
        public static void Feedback(string s, int i)
        {         
            if(i == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (i == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.Write(s);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ChangeCyan(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(s);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        // Clear Previous Line & Return
        public static void ClearAtLine(int line1,int line2)
        {
            Console.SetCursorPosition(0, Console.CursorTop - line1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - line2);
        }
    }
}