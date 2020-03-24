using System;
using System.IO;
using Library;
namespace Kneiss_Jamie_Final
{
    public class Assignment
    {
        private Menu _menu;
        private  DM _dm;
        private Adventurer _adventurer;
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
                    CreatePlayer();
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
        private void CreatePlayer()
        {
            string userName = Validation.ValidateString("Please enter your username", 1);
            string type = Validation.ValidateString("Are you a DM, or an Adventurer?", 1);
            while (!(type.ToLower() == "DM" || type.ToLower() == "Adventurer"))
            {
                type = Validation.ValidateString("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer", 1);
            }
            if (type.ToLower() == "DM")
            {
                string campaign = Validation.ValidateString("What is your campaign name?", 1);
                _dm = new DM(userName, campaign);
            }
            else
            {
                string charName = Validation.ValidateString("What is your character's name?", 1);
                string charRace = Validation.ValidateString("What is your character's race?", 1);
                _menu = new Menu("Human", "Elf", "Dwarf", "Orc");
                switch (charRace)
                {
                    case "human":
                    case "Human":
                    case "1":
                        charRace = "Human";
                        break;
                    case "elf":
                    case "Elf":
                    case "2":
                        charRace = "Elf";
                        break;
                    case "dwarf":
                    case "Dwarf":
                    case "3":
                        charRace = "Dwarf";
                        break;
                    case "orc":
                    case "Orc":
                    case "4":
                        charRace = "Orc";
                        break;
                    default:
                        Validation.Resubmit("invalid input");
                        break;               
                }
                string charClass = Validation.ValidateString("What is your character's class?", 1);
                _menu = new Menu("Rogue", "Bard", "Wizard", "Fighter");
                switch(charClass)
                {
                    case "rogue":
                    case "Rogue":
                        charClass = "Rogue";
                        break;
                    case "bard":
                    case "Bard":
                        charClass = "Bard";
                        break;
                    case "wizard":
                    case "Wizard":
                        charClass = "Wizard";
                        break;
                    case "fighter":
                    case "Fighter":
                        charClass = "Fighter"; 
                        break;
                    default:
                        Validation.Resubmit("invalid input");
                        break;
                }
                _adventurer = new Adventurer(userName, charName, charRace, charClass);
                Console.WriteLine("Let's roll your stats.");
                _adventurer.RollDice();
            }
        }
        private void DisplayCharacter()
        {

        }
        private void RemoveCharacter()
        {

        }
        private void RollDice()
        {
        }
        private void MainMenu()
        {
            Console.Clear();
            //menu.Title = "Main Menu";
            _menu = new Menu("Create Character", "View Characters", "Remove Character", "Roll Die", "Combat Scenario", "Exit");
            _menu.Display();
            Select();
        }
    }
}