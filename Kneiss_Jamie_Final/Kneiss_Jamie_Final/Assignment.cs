﻿using System;
using System.IO;
using Library;
namespace Kneiss_Jamie_Final
{
    public class Assignment
    {
        private Menu menu;
        public Assignment()
        {
            MainMenu();
        }
        public void Select()
        {
            string userSelection = Validation.ValidateString("Make a selection:", 2).ToLower();
            switch (userSelection)
            {
                case "1":
                    CreateCharacter();
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "2":
                    DisplayCharacter();
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "3":

                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "4":
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "5":
                    break;
                case "6":
                case "exit":
                    Utility.Goodbye("Goodbye");
                    break;
                default:
                    Validation.Resubmit("Invalid input");
                    MainMenu();
                    break;
            }
        }
        private void CreateCharacter()
        {

        }
        private void DisplayCharacter()
        {
        }
        private void RemoveCharacter()
        {

        }
        private void RollDice()
        {
            Dice die;
            menu = new Menu("D4", "D6", "D8", "D10", "Percentile", "D12", "D20");
            string userSelection = Validation.ValidateString("Make a selection:", 2).ToLower();
            switch (userSelection)
            {
                case "1":
                    die = new D4();
                    break;
                case "2":
                    die = new D8();
                    break;
                case "3":
                    die = new D6();
                    break;
                case "4":
                    die = new D10();
                    break;
                case "5":
                    die = new Percentile();
                    break;
                case "6":
                    die = new D12();
                    break;
                case "7":
                    die = new D20();
                    break;
                case "8":
                case "exit":
                    Utility.Goodbye("Goodbye");
                    break;
                default:
                    Validation.Resubmit("Invalid input");
                    MainMenu();
                    break;
            }
        }
        private void MainMenu()
        {
            Console.Clear();
            //menu.Title = "Main Menu";
            menu = new Menu("Create Character", "View Characters", "Remove Character", "Roll Die", "Combat Scenario", "Exit");
            menu.Display();
            Select();
        }
    }
}