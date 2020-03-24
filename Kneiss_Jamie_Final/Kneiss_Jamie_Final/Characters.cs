using System;
using System.Collections.Generic;

namespace Kneiss_Jamie_Final
{
    public abstract class Player
    {
        public string UserName { get; set; }
        public string UserType { get; set; }
        public Player(string userName)
        {
            UserName = userName;
        }
    }
    public class Adventurer : Player, IDice
    {
        public string CharName { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        private Dictionary<string, int> _charStats;

        public Adventurer(string userName, string charName, string charRace, string charClass) : base (userName)
        {
            UserType = "Adventurer";
            CharName = charName;
            Race = charRace;
            Class = charClass;
        }
        public int RollDice()
        {
            Random rnd = new Random();
            int roll = 0;
            for (int i = 0; i < 4; i++)
            {
                roll += rnd.Next(1, 6);

            }
            return roll;
        }
        int IDice.StatRoll()
        {
            Random rnd = new Random();
            int roll = 0;
            for (int i = 0; i < 4; i++)
            {
                roll += rnd.Next(1, 6);

            }
            return roll;
        }
    }
    public class DM : Player
    {
        public string Campaign { get; set; }
        public DM(string userName, string campaignName) : base (userName)
        {
            UserType = "DM";
            Campaign = campaignName;
        }
    }
    public interface IDice
    {
        int StatRoll();
    }
    
}
