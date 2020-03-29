class Assignment{
        _dice;
        _username;
        _type;
        _campaign;
        _partySize;
        _charName;
        _charRace;
        _charClass;
    constructor()
    {
        this.validation = new Validation();
        this.assignment = new Assignment();
        this.utility = new Utility();
        this.players = [];
        this.dm = null;
        this.adventurer = null;
        this.players = new Array;
        this._removeChar = false;
        this.CreateData();
        this.LoadData();
        this.MainMenu();
    }
    CreatePlayer()
    {
        console.clear();
        _menu.NewTitle("Create Player");
        _username = this.validation.askQuestion("Please enter a username: ", 1);
        foreach (Player in this.players)
        {
            while (_username == player1.UserName)
            {
                _username = validation.ValidateString("It seems that username already exists\r\nPlease enter a username: ", 1);
            }
        }
        _type = validation.askQuestion("Are you a DM, or an Adventurer?: ", 1);
        while (!(_type.toLowerCase() == "dm" || _type.toLowerCase() == "adventurer"))
        {
            _type = validation.askQuestion("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
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
    CreateDM()
    {
        if (_dm == null)
        {
            this._campaign = validation.ValidateString("What is your campaign name?: ", 1);
            this._partySize = validation.Validatelet("How many adventurers are in your campaign?: ", 1);
            this._dm = new DM(_username, _campaign, _partySize);
            _players.Add(_dm);
        }
        else
        {
            let response = validation.ValidateString("I'm sorry, it seems there's already a DM.\r\n Would you like to play as an Adventurer?: ", 1);
            while (response.toLowerCase() != "no" && response.ToLower() != "yes")
            {
                response = validation.ValidateString("Yes or No, would you like to switch to Adventurer?: ", 1);
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
    CreateAdventurer(){
        _charName = validation.askQuestion("What is your character's name?: ", 1);
        let _menu = new Menu("Human", "Elf", "Dwarf", "Orc");
        _menu.MinDisplay();
        _charRace = validation.askQuestion("What is your character's race?: ", 1);
        SelectRace(_charRace);
        _menu = new Menu("Rogue", "Bard", "Wizard", "Fighter");
        _menu.MinDisplay();
        _charClass = validation.askQuestion("What is your character's class?: ", 1);
        this.SelectClass(_charClass);
        this._adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
        this.RollStats();
        _players.Add(_adventurer);
    }
    RollStats(){
        _dice = new Adventurer(_username);
        console.log("Let's roll your stats.");
        let stats = [];
        let strength = _dice.StatRoll();        
        stats.push(strength);
        let dexterity = _dice.StatRoll();
        stats.push(dexterity);
        let constitution = _dice.StatRoll();
        stats.push(constitution);
        let wisdom = _dice.StatRoll();
        stats.push(wisdom);
        let intelligence = _dice.StatRoll();
        stats.push(intelligence);
        let charisma = _dice.StatRoll();
        stats.push(charisma);
        this._adventurer.CharStats = stats;
    }
    DisplayCharacter(){
        let validation = new Validation();
        if (_players.Count == 0){
            let utility = new Utility();
            utility.Feedback("You must first add a player.", 1);
            menu.MainMenu();
        }
        else{
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
            console.log();
            let x = 1;
            foreach (Player in this.players){
                this.CreateAdventurer();
                let utility = new Utility();
                utility.ChangeCyan("[{x}]: ");
                utility.Feedback(`${ "User Name:",-15}`, 3);
                validation.displayMessage(` ${player.userName,-12}`, Console.ForegroundColor = ConsoleColor.DarkMagenta);
                utility.Feedback("Account Type:", 3);
                if (Player === DM)
                {
                    Utility.Feedback(`${player.UserType,-12}\r\n`, 1);
                }
                else
                {
                    Utility.Feedback(`${player.UserType,-12}\r\n`, 2);
                }
                x++;
            }
            let info = validation.askQuestion("Which player you like more information on?: ");
            while (info < 1 || info > _players.Count)
            {
                info = validation.askForNumber(`Please choose a valid number between 1 and ${_players.Count}`);
            }
            info -= 1;
            if (players[info]  == Adventurer)
            {
                Utility.Feedback("Character Info\r\n", 3);
                console.log(`${"Name:",-14} ${(Adventurer).CharName}`);
                console.log(`${"Race:", -14} ${(Adventurer).Race}`);
                console.log(`${"Class:", -14} ${(Adventurer).Class}`);
                Utility.Feedback("Stats\r\n", 3);
                foreach(KeyValuePair<string,int> kvp in this.adventurer.CharStats)
                {
                    console.log(`${kvp.Key+":", -14} ${kvp.Value}`);
                }
            }
            else if (_players[info] == DM)
            {
                Utility.Feedback("Campaign Info\r\n", 3);
                console.log(`${"Name:",-12} ${DM.Campaign}`);
                console.log(`${"Party Size:",-12} ${DM.PartySize}`);                   
            }
            else
            {
                console.log("Not sure how you managed this one, Good job doofus.");
            }
            console.log();
            
        }
        _removeChar = false;
    }
    RemoveCharacter()
    {
        Console.Clear();
        _removeChar = true;
        DisplayCharacter();

        let remove = Validation.ValidateInt("Choose a player to remove.", 0);

        while (remove > _players.Count || remove < 1)
        {
            Utility.Feedback("No such player", 1);
            remove = Validation.ValidateInt("Choose a player to remove.", 0);
        }
        remove -= 1;
        Utility.Feedback(`${_players[remove].UserName} has been deleted\r\n`, 2);
        Utility.Feedback(`${_players[remove].UserName}: {_players[remove].Quit()}`, 1);
        _players.RemoveAt(remove);
        Thread.Sleep(750);
        MainMenu();
    }
}