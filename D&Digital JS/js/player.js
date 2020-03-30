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
        super(username);
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
    constructor(username, charName, charRace, charClass)
    {
        super(username);
        this.UserType = "Adventurer";
        this.CharName = charName;
        this.Race = charRace;
        this.Class = charClass;
    }   
    Quit()
    {
        return `Hope to see you adventuring again someday, ${UserName}!`;
    }
}