class Player{
    constructor(username)
    {
        this._userName = username;
    }
    Quit()
    {
        return `This is ${this._userName} and I'm finished.`;
    }
}
class DM extends Player{
    Campaign;
    PartySize;
    constructor(username, campaignName, size)
    {
        super(username)
        this.UserType = "DM";
        this.Campaign = campaignName;
        this.PartySize = size;
    }
    Quit()
    {
        return `Alright! Sorry to see you leave, but we look forward to your next epic story, ${UserName}`;
    }  
}
class Adventurer extends Player{
    CharName;
    Race;
    Class;
    CharStats;
    constructor(username, charName, charRace, charClass)
    {
        super(username);
        UserType = "Adventurer";
        CharName = charName;
        Race = charRace;
        Class = charClass;
    }
    StatRoll()
    {
        Math.random();
        let roll = 0;
        for (int i = 0; i < 4; i++)
        {
            roll += rnd.Next(1, 6);
        }
        return roll;
    }
    DiceRoll(sides, number)
    {
        Math.random();
        let total = 0;
        let roll = 0;
        for (int i = 0; i < number; i++)
        {
            roll = rnd.Next(1, sides);
            Console.WriteLine("You rolled a " + roll);
            total += roll;
        }
        return total;
    }
    Quit()
    {
        return `Hope to see you adventuring again someday, ${UserName}!`;
    }
}