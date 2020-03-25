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
        public virtual string Quit()
        {
            return $"This is {UserName} and I'm finished.";
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
        public int RollStats()
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
        public override string Quit()
        {
            return $"Hope to see you adventuring again someday, {UserName}!";
        }
    }
    public class DM : Player
    {
        public string Campaign { get; set; }
        public int PartySize { get; set; }
        public List<Adventurer> Party { get; set; }
        public DM(string userName, string campaignName, int size) : base (userName)
        {
            UserType = "DM";
            Campaign = campaignName;
            PartySize = size;
        }
        public override string Quit()
        {
            return $"Alright! Sorry to see you leave, but we look forward to your next epic story, {UserName}";
        }
    }
    public interface IDice
    {
        int StatRoll();
    }
}
