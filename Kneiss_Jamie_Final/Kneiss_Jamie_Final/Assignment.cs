﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Library;
namespace Kneiss_Jamie_Final
{
    public class Assignment
    {
        private Menu _menu;

        private  DM _dm;
        private Adventurer _adventurer;
        private List<Player> _players;

        //private List<Adventurer> _party;

        private bool _removeChar;

        #region File Strings
        private string _file = "players.txt";
        private string _json = "campaign.json";
        private string _directory = @"../../../output/";
        #endregion

        #region Players
        private string _username;
        private string _type;
        private string _campaign;
        private int _partySize;
        private string _charName;
        private string _charRace;
        private  string _charClass;
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
            _menu = new Menu("Create Player", "View Player", "Remove Player", "Roll Die", "Save","Exit");
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

        private void RollDice()
        {
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
        private void CreatePlayer()
        {
            Console.Clear();
            _menu.NewTitle("Create Player");
            _username = Validation.ValidateString("Please enter your username: ", 1);
            _type = Validation.ValidateString("Are you a DM, or an Adventurer?: ", 1);
            while (!(_type.ToLower() == "dm" || _type.ToLower() == "adventurer"))
            {
                _type = Validation.ValidateString("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
            }
            if (_type.ToLower() == "dm")
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
                }
            }
            else
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
                RollStats();
                _adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
                _players.Add(_adventurer);

                foreach (Player player in _players)
                {
                    Console.WriteLine(player.UserName);
                    Console.WriteLine(player.UserType);
                }
                foreach (KeyValuePair<string, int> kvp in _adventurer.CharStats)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            Console.WriteLine("It seems we're at capacity. Remove a player first or try something else.");
            MainMenu();
        }
        private void DisplayCharacter()
        {
            if (_players.Count == 0)
            {
                if (_players.Count == 0)
                {
                    Utility.Feedback("You must first add a player.", 1);
                }             
                MainMenu();
            }
            else
            {
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
                int x = 0;
                foreach (Player player in _players)
                {
                    Utility.ChangeCyan($"[{x + 1}]: ");
                    Utility.Feedback($"{ "User Name:",-15}", 3);
                    Console.Write($" {player.UserName,-12}", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                    Utility.Feedback($" Account Type:", 3);            
                    
                    if (player is Adventurer)
                    {
                        Utility.Feedback($" {player.UserType,-12}\r\n", 1);
                        Console.WriteLine($"     {"Character Name:", -15} {((Adventurer)player).CharName}");
                        Console.WriteLine($"     {"Race:", -15} {((Adventurer)player).Race}");
                        Console.WriteLine($"     {"Class:", -15} {((Adventurer)player).Class}");
                    }
                    else
                    {
                        Utility.Feedback($" {player.UserType,-12}\r\n", 2);
                        Console.WriteLine($"     {"Campaign Name:", -15} {((DM)player).Campaign}");
                        Console.WriteLine($"     {"Party Size:", -15} {((DM)player).PartySize}");
                    }
                    x++;
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

            Utility.Feedback($"{_players[remove - 1].UserName} has been let go\r\n", 2);
            Utility.Feedback($"{_players[remove - 1].UserName}: {_players[remove - 1].Quit()}", 1);
            _players.RemoveAt(remove - 1);
            Thread.Sleep(750);
            MainMenu();
        }
        private void RollStats()
        {
            Console.WriteLine("Let's roll your stats.");
            int strength = _adventurer.RollStats();
            _adventurer.CharStats.Add("Strength", strength);
            int dexterity = _adventurer.RollStats();
            _adventurer.CharStats.Add("Dexterity", dexterity);
            int constitution = _adventurer.RollStats();
            _adventurer.CharStats.Add("Constitution", constitution);
            int wisdom = _adventurer.RollStats();
            _adventurer.CharStats.Add("Wisdom", wisdom);
            int intelligence = _adventurer.RollStats();
            _adventurer.CharStats.Add("Intelligence", intelligence);
            int charisma = _adventurer.RollStats();
            _adventurer.CharStats.Add("Charisma", charisma);
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
                foreach (Player worker in _players)
                {
                    sw.WriteLine($"{worker.UserName}, {worker.UserType}");
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
                    if (data.Length == 3)
                    {
                        _username = data[0];
                        _campaign = data[1];
                        _partySize = int.Parse(data[2]);
                        Player player1 = new DM(_username, _campaign, _partySize);
                        _players.Add(player1);
                    }
                    else
                    {
                        _username = data[0];
                        _charName = data[1];
                        _charRace = data[2];
                        _charClass = data[3];
                        Player player = new Adventurer(_username, _charName, _charRace, _charClass);
                        _players.Add(player);
                    }                    
                }
            }
            //SaveJSON();
        }
        private void SaveJSON()
        {
            using (StreamWriter sw = new StreamWriter(_directory + _json))
            {
                sw.Write("[");
                int i = 0;
                foreach (Player worker in _players)
                {
                    sw.WriteLine("{");
                    sw.WriteLine($"\"Username\" : \"{worker.UserName}\",");
                    sw.WriteLine($"\"Type\" : \"{worker.UserType}\",");                    
                    if (worker is DM)
                    {
                        sw.WriteLine($"\"Campaign\" : \"{((DM)worker).Campaign}\",");
                        sw.WriteLine($"\"Party Size\" : \"{((DM)worker).PartySize}");
                    }
                    else if (worker is Adventurer)
                    {
                        sw.WriteLine($"\"Character Name\" : \"{((Adventurer)worker).CharName}\",");
                        sw.WriteLine($"\"Character Race\" : \"{((Adventurer)worker).Race}\",");
                        sw.WriteLine($"\"Character Class\" : \"{((Adventurer)worker).Class}\",");
                    }
                    i++;
                    if (i < _players.Count)
                    {
                        sw.WriteLine("},");
                    }
                    else
                    {
                        sw.WriteLine("}");
                    }
                }
                sw.Write("]");
            }
            Utility.Feedback("Saved Players to File", 2);
            Thread.Sleep(700);
            MainMenu();
        }
        #endregion
    }
}