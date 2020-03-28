using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Library;
namespace Kneiss_Jamie_Final
{
    public class Assignment
    {
        #region 
        private Menu _menu;
        private DM _dm;
        private IDice _dice;
        private Adventurer _adventurer;
        private List<Player> _players;
        #endregion

        #region File Strings
        private string _file = "players.txt";
        private string _json = "campaign.json";
        private string _directory = @"../../../output/";
        #endregion

        #region Fields
        private string _username;
        private string _type;
        private string _campaign;
        private int _partySize;
        private string _charName;
        private string _charRace;
        private string _charClass;
        private bool _removeChar;
        #endregion

        public Assignment()
        {
            _dm = null;
            _adventurer = null;
            _players = new List<Player>();
            _removeChar = false;
            CreateData();
            LoadData();
            MainMenu();
        }
        #region Navigation
        private void MainMenu()
        {
            Console.Clear();
            _menu = new Menu("Create Player", "View Player", "Remove Player", "Roll Die", "Save", "Exit");
            _menu.MaxDisplay();
            Select();
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
                    RemoveCharacter();
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "4":
                    RollDice();
                    Utility.Continue("Press any key to continue");
                    MainMenu();
                    break;
                case "5":
                    SaveData();
                    break;
                case "6":
                    Utility.Goodbye("Goodbye");
                    break;
                default:
                    Validation.Resubmit("Invalid input");
                    MainMenu();
                    break;
            }
        }
        private string SelectRace(string race)
        {
            switch (race)
            {
                case "human":
                case "Human":
                case "1":
                    race = "Human";
                    break;
                case "elf":
                case "Elf":
                case "2":
                    race = "Elf";
                    break;
                case "dwarf":
                case "Dwarf":
                case "3":
                    race = "Dwarf";
                    break;
                case "orc":
                case "Orc":
                case "4":
                    race = "Orc";
                    break;
                default:
                    Validation.Resubmit("invalid input");
                    break;
            }
            return race;
        }
        private string SelectClass(string cClass)
        {
            switch (cClass)
            {
                case "rogue":
                case "Rogue":
                case "1":
                    cClass = "Rogue";
                    break;
                case "bard":
                case "Bard":
                case "2":
                    cClass = "Bard";
                    break;
                case "wizard":
                case "Wizard":
                case "3":
                    cClass = "Wizard";
                    break;
                case "fighter":
                case "Fighter":
                case "4":
                    cClass = "Fighter";
                    break;
                default:
                    Validation.Resubmit("invalid input");
                    break;
            }
            return cClass;
        }
        #endregion
        #region Assignment Methods
        #region Player Creation
        private void CreatePlayer()
        {
            Console.Clear();
            _menu.NewTitle("Create Player");
            _username = Validation.ValidateString("Please enter a username: ", 1);
            foreach (Player player1 in _players)
            {
                while (_username == player1.UserName)
                {
                    _username = Validation.ValidateString("It seems that username already exists\r\nPlease enter a username: ", 1);
                }
            }
            _type = Validation.ValidateString("Are you a DM, or an Adventurer?: ", 1);
            while (!(_type.ToLower() == "dm" || _type.ToLower() == "adventurer"))
            {
                _type = Validation.ValidateString("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
            }
            if (_type.ToLower() == "dm")
            {
                CreateDM();
            }
            else
            {
                CreateAdventurer();
            }
            MainMenu();
        }
        private void CreateDM()
        {
            if (_dm == null)
            {
                _campaign = Validation.ValidateString("What is your campaign name?: ", 1);
                _partySize = Validation.ValidateInt("How many adventurers are in your campaign?: ", 1);
                _dm = new DM(_username, _campaign, _partySize);
                _players.Add(_dm);
            }
            else
            {
                string response = Validation.ValidateString("I'm sorry, it seems there's already a DM.\r\n Would you like to play as an Adventurer?: ", 1);
                while (response.ToLower() != "no" && response.ToLower() != "yes")
                {
                    response = Validation.ValidateString("Yes or No, would you like to switch to Adventurer?: ", 1);
                }
                if (response.ToLower() == "yes")
                {
                    CreateAdventurer();
                }
                else
                {
                    MainMenu();
                }
            }
        }
        private void CreateAdventurer()
        {
            _charName = Validation.ValidateString("What is your character's name?: ", 1);
            _menu = new Menu("Human", "Elf", "Dwarf", "Orc");
            _menu.MinDisplay();
            _charRace = Validation.ValidateString("What is your character's race?: ", 1);
            SelectRace(_charRace);
            _menu = new Menu("Rogue", "Bard", "Wizard", "Fighter");
            _menu.MinDisplay();
            _charClass = Validation.ValidateString("What is your character's class?: ", 1);
            SelectClass(_charClass);

            _adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
            RollStats();
            _players.Add(_adventurer);
        }
        private void RollStats()
        {
            _dice = new Adventurer(_username);
            Console.WriteLine("Let's roll your stats.");
            _adventurer.CharStats = new Dictionary<string, int>();
            int strength = _dice.StatRoll();
            _adventurer.CharStats.Add("Strength", strength);
            int dexterity = _dice.StatRoll();
            _adventurer.CharStats.Add("Dexterity", dexterity);
            int constitution = _dice.StatRoll();
            _adventurer.CharStats.Add("Constitution", constitution);
            int wisdom = _dice.StatRoll();
            _adventurer.CharStats.Add("Wisdom", wisdom);
            int intelligence = _dice.StatRoll();
            _adventurer.CharStats.Add("Intelligence", intelligence);
            int charisma = _dice.StatRoll();
            _adventurer.CharStats.Add("Charisma", charisma);
        }
        #endregion
        private void DisplayCharacter()
        {
            if (_players.Count == 0)
            {
                Utility.Feedback("You must first add a player.", 1);
                MainMenu();
            }
            else
            {
                _players.Sort();
                Console.Clear();
                if (_removeChar == true)
                {
                    _menu.NewTitle("Remove Player");
                }
                else
                {
                    _menu.NewTitle("Display Character");
                }
                Console.WriteLine();
                int x = 1;
                foreach (Player player in _players)
                {
                    Utility.ChangeCyan($"[{x}]: ");
                    Utility.Feedback($"{ "User Name:",-15}", 3);
                    Console.Write($" {player.UserName,-12}", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                    Utility.Feedback($" Account Type:", 3);
                    if (player is DM)
                    {
                        Utility.Feedback($"{player.UserType,-12}\r\n", 1);
                    }
                    else
                    {
                        Utility.Feedback($"{player.UserType,-12}\r\n", 2);
                    }
                    x++;
                }
                int info = Validation.ValidateInt("Which player you like more information on?: ", 1);
                while (info < 1 || info > _players.Count)
                {
                    Console.Write("Please choose a valid number");
                    info = Validation.ValidateInt($" between 1 and {_players.Count}", 1);
                }
                info -= 1;
                if (_players[info] is Adventurer)
                {
                    Utility.Feedback("Character Info\r\n", 3);
                    Console.WriteLine($"{"Name:",-14} {((Adventurer)_players[info]).CharName}");
                    Console.WriteLine($"{"Race:", -14} {((Adventurer)_players[info]).Race}");
                    Console.WriteLine($"{"Class:", -14} {((Adventurer)_players[info]).Class}");
                    Utility.Feedback("Stats\r\n", 3);
                    foreach(KeyValuePair<string,int> kvp in ((Adventurer)_players[info]).CharStats)
                    {
                        Console.WriteLine($"{kvp.Key+":", -14} {kvp.Value}");
                    }
                }
                else if (_players[info] is DM)
                {
                    Utility.Feedback("Campaign Info\r\n", 3);
                    Console.WriteLine($"{"Name:",-12} {((DM)_players[info]).Campaign}");
                    Console.WriteLine($"{"Party Size:",-12} {((DM)_players[info]).PartySize}");                   
                }
                else
                {
                    Console.WriteLine("Not sure how you managed this one, Good job doofus.");
                }
                Console.WriteLine();
            }
            _removeChar = false;
        }
        private void RemoveCharacter()
        {
            Console.Clear();
            _removeChar = true;
            DisplayCharacter();

            int remove = Validation.ValidateInt("Choose a player to remove.", 0);

            while (remove > _players.Count || remove < 1)
            {
                Utility.Feedback("No such employee", 1);
                remove = Validation.ValidateInt("Choose a player to remove.", 0);
            }
            remove -= 1;
            Utility.Feedback($"{_players[remove].UserName} has been let go\r\n", 2);
            Utility.Feedback($"{_players[remove].UserName}: {_players[remove].Quit()}", 1);
            _players.RemoveAt(remove);
            Thread.Sleep(750);
            MainMenu();
        }
        private void RollDice()
        {
            Console.Clear();
            _menu.NewTitle("Roll Dice");
            int number = Validation.ValidateInt("How many dice will you be rolling here?: ", 2);
            while (number > 9)
            {
                number = Validation.ValidateInt("Try rolling less than 10 dice: ", 1);
            }
            _menu = new Menu("D4", "D6", "D8", "D10", "D12", "D20");
            _menu.MinDisplay();
            string type = Validation.ValidateString("Which dice type would you like to use?", 2);
            SelectDice(type, number);
        }
        private void SelectDice(string type, int number)
        {
            _dice = new Adventurer(_username);
            switch (type.ToLower())
            {
                case "1":
                case "d4":                 
                    _dice.DiceRoll(4, number);
                    break;
                case "2":
                case "d6":
                    _dice.DiceRoll(6, number);
                    break;
                case "3":
                case "d8":
                    _dice.DiceRoll(8, number);
                    break;
                case "4":
                case "d10":
                    _dice.DiceRoll(10, number);
                    break;
                case "5":
                case "d12":
                    _dice.DiceRoll(12, number);
                    break;
                case "6":
                case "d20":
                    _dice.DiceRoll(20, number);
                    break;
                default:
                    Validation.Resubmit("invalid input");
                    break;
            }
        }
        #endregion
        #region File I/O & JSON Data
        private void CreateData()
        {
            Directory.CreateDirectory(_directory);
            Console.WriteLine("Directory 'output' Created.");
            if (!File.Exists(_directory + _file) || !File.Exists(_directory + _json))
            {
                if (!File.Exists(_directory + _file))
                {
                    File.Create(_directory + _file).Dispose();
                    Console.WriteLine($"File '{_file}' Created.");
                }
                else if (!File.Exists(_directory + _json))
                {
                    File.Create(_directory + _json).Dispose();
                    Console.WriteLine($"File '{_json}' Created.");
                }
            }
            else
            {
                Console.WriteLine($"Files '{_file}' and '{_json}' Already Exist.");
                Console.WriteLine("Proceding\r\n");
            }
        }
        private void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(_directory + _file))
            {
                foreach (Player player in _players)
                {
                    sw.Write($"{player.UserName},");
                    if (player is DM)
                    {
                        sw.WriteLine($"{((DM)player).Campaign},{((DM)player).PartySize}");
                    }
                    else
                    {
                        sw.Write($"{((Adventurer)player).CharName},{((Adventurer)player).Race},{((Adventurer)player).Class}");
                        int i = 1;
                        string stats = "";
                        foreach(KeyValuePair<string, int> kvp in ((Adventurer)player).CharStats)
                        {
                            if (i < 6)
                            {
                                stats += kvp.Value + ".";
                            }
                            else
                            {
                                stats += kvp.Value;
                            }
                            i++;
                        }
                        sw.WriteLine($",{stats}");
                    }
                }
            }
            Utility.Feedback("Saved Players to File", 2);
            Thread.Sleep(700);
            MainMenu();
        }
        private void LoadData()
        {
            using (StreamReader sr = new StreamReader(_directory + _file))
            { 
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split(',');
                    if (data.Length != 3)
                    {
                        _username = data[0];
                        _charName = data[1];
                        _charRace = data[2];
                        _charClass = data[3];
                        Adventurer player = new Adventurer(_username, _charName, _charRace, _charClass);
                        _players.Add(player);
                        player.CharStats = new Dictionary<string, int>();
                        string[] stats = data[4].Split('.');
                        int strength = int.Parse(stats[0]);
                        player.CharStats.Add("Strength", strength);
                        //statDic.Add("Strength", strength);                       
                        int dexterity = int.Parse(stats[1]);
                        player.CharStats.Add("Dexterity", dexterity);
                        int constitution = int.Parse(stats[2]);
                        player.CharStats.Add("Constitution", constitution);
                        int wisdom = int.Parse(stats[3]);
                        player.CharStats.Add("Wisdom", wisdom);
                        int intelligence = int.Parse(stats[4]);
                        player.CharStats.Add("Intelligence", intelligence);
                        int charisma = int.Parse(stats[5]);
                        player.CharStats.Add("Charisma", charisma);
                    }
                    else
                    {       
                        _username = data[0];
                        _campaign = data[1];
                        _partySize = int.Parse(data[2]);
                        DM player1 = new DM(_username, _campaign, _partySize);
                        _players.Add(player1);
                    }                  
                }
            }
        }
        #endregion
    }
}