class Assignment{
    #region 
        window._menu;
        _dm;
        _dice;
        _adventurer;
        _players;

        _username;
        _type;
        _campaign;
        _partySize;
        _charName;
        _charRace;
        _charClass;
        bool_removeChar;
    constructor()
    {
        let validation = new Validation();
        let assignment = new Assignment();
        let player
        this.menu = new 
        this._dm = null;
        this._adventurer = null;
        this._players = new Array;
        this._removeChar = false;
        CreateData();
        LoadData();
        MainMenu();
    }
    CreatePlayer()
    {
        console.clear();
        _menu.NewTitle("Create Player");
        _username = validation.ValidateString("Please enter a username: ", 1);
        foreach (Player player in _players)
        {
            while (_username == player1.UserName)
            {
                _username = validation.ValidateString("It seems that username already exists\r\nPlease enter a username: ", 1);
            }
        }
        _type = validation.ValidateString("Are you a DM, or an Adventurer?: ", 1);
        while (!(_type.ToLower() == "dm" || _type.ToLower() == "adventurer"))
        {
            _type = validation.ValidateString("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
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
            _campaign = validation.ValidateString("What is your campaign name?: ", 1);
            _partySize = validation.ValidateInt("How many adventurers are in your campaign?: ", 1);
            _dm = new DM(_username, _campaign, _partySize);
            _players.Add(_dm);
        }
        else
        {
            string response = validation.ValidateString("I'm sorry, it seems there's already a DM.\r\n Would you like to play as an Adventurer?: ", 1);
            while (response.ToLower() != "no" && response.ToLower() != "yes")
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
    CreateAdventurer()
    {
        _charName = validation.ValidateString("What is your character's name?: ", 1);
        _menu = new Menu("Human", "Elf", "Dwarf", "Orc");
        _menu.MinDisplay();
        _charRace = validation.ValidateString("What is your character's race?: ", 1);
        SelectRace(_charRace);
        _menu = new Menu("Rogue", "Bard", "Wizard", "Fighter");
        _menu.MinDisplay();
        _charClass = validation.ValidateString("What is your character's class?: ", 1);
        SelectClass(_charClass);

        _adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
        RollStats();
        _players.Add(_adventurer);
    }
}