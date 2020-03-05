using System;
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
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "2":
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
        private void MainMenu()
        {
            Console.Clear();
            //menu.Title = "Main Menu";
            menu = new Menu("Create Character", "Remove Movie", "Display Movie [By Genre]", "Display [All]", "", "Exit");
            menu.Display();
            Select();
        }
    }
}