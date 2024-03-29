﻿using System;
using System.Collections.Generic;

namespace Kneiss_Jamie_Final
{
    public abstract class Player : IComparable<Player>
    {
        public string UserName { get; set; }
        public string UserType { get; set; }
        public Player(string userName)
        {
            UserName = userName;
        }
        public virtual string Quit()
        {
            return $"This is {UserName} and I'm finished.";
        }
        public int CompareTo(Player other)
        {
            // If User Types are Equal, Sort by Username
            if (UserType == other.UserType)
            {
                return UserName.CompareTo(other.UserName);
            }
            return UserType.CompareTo(other.UserType);
        }
    }
    public class Adventurer : Player, IDice
    {
        public string CharName { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public Dictionary<string, int> CharStats { get; set; }

        public Adventurer(string userName, string charName, string charRace, string charClass) : base (userName)
        {
            UserType = "Adventurer";
            CharName = charName;
            Race = charRace;
            Class = charClass;
        }
        public Adventurer(string userName) : base(userName)
        {
            UserType = "Adventurer";
        }

        int IDice.StatRoll()
        {
            Random rnd = new Random();
            int roll = 0;
            // Roll 4 D6 (6 Sided) Dice To find Each Stat
            for (int i = 0; i < 4; i++)
            {
                roll += rnd.Next(1, 6);
            }
            return roll;
        }
        public int DiceRoll(int sides, int number)
        {
            Random rnd = new Random();
            int total = 0;
            int roll = 0;
            // Roll X amount of Y Sided Dice.
            for (int i = 0; i < number; i++)
            {
                // Find Roll
                roll = rnd.Next(1, sides);
                Console.WriteLine("You rolled a " + roll);
                // Add Roll to Total
                total += roll;
            }
            return total;
        }
        public override string Quit()
        {
            return $"Hope to see you adventuring again someday, {UserName}!";
        }
    }
    public class DM : Player
    {
        public string Campaign { get; set; }
        public int PartySize { get; set; }
        public DM(string userName, string campaignName, int size) : base (userName)
        {
            UserType = "DM";
            Campaign = campaignName;
            PartySize = size;
        }
        public DM(string userName) : base (userName)
        {
            UserType = "DM";
        }
        public override string Quit()
        {
            return $"Alright! Sorry to see you leave, but we look forward to your next epic story, {UserName}";
        }     
    }
    public interface IDice
    {
        int DiceRoll(int sides, int number);
        int StatRoll();
    }
}
