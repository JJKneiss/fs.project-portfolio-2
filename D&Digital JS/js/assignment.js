const characters = [];
const storedCharacters = localStorage.getItem("characters");

let _username, _type;
let _campaign, _partySize;
let _charName, _charRace, _charClass;
let _players = [], items = ["Create User", "View User", "Delete User", "Roll Dice", "Save Data", "Exit"];
let valid = new Validation(), util = new Utility(), menu = new Menu(items);
let name, race, classes, message;
let _adventurer, _dm;
let _removeChar = false;
class Assignment{
    constructor(){}
    startAll(event){
        event.preventDefault();
        assignment.mainMenu(items);
        assignment.select();
    }
    mainMenu(items){   
        console.clear();
        console.table(items);
    }
    select(){
        let userSelection = valid.askQuestion("Make a selection:", 2).toLowerCase();
        switch (userSelection)
        {
            case "0":
            case "create":
                assignment.createPlayer();
                break;
            case "1":
            case "view":
                assignment.characterList();                   
                break;
            case "2":
                // Set _removeChar Track
                _removeChar = true;
                assignment.characterList();
                break;
            case "3":
                assignment.rollDice();                    
                break;
            case "4":
                assignment.saveData();
                break;
            case "5":
                util.Goodbye("Goodbye");
                break;
            default:
                valid.displayMessage("invalid option, please resubmit")
                assignment.mainMenu(items);
                break;
        }
    }
    selectRace(race)
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
                valid.displayMessage("invalid option, please resubmit")
                assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
                break;
        }
        return race;
    }
    selectClass(cClass)
        {
            switch (cClass)
            {
                case "rogue":
                case "Rogue":
                case "0":
                    cClass = "Rogue";
                    break;
                case "bard":
                case "Bard":
                case "1":
                    cClass = "Bard";
                    break;
                case "wizard":
                case "Wizard":
                case "2":
                    cClass = "Wizard";
                    break;
                case "fighter":
                case "Fighter":
                case "3":
                    cClass = "Fighter";
                    break;
                default:
                    let _class = valid.askQuestion("invalid option, please resubmit")
                    assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
                    assignment.selectClass(_class);
                    break;
            }
            return cClass;
        }
    createPlayer(){      
        console.clear();
        console.log("%cCreate Player", "color:yellow");
        console.log("--------------------")
        //menu.NewTitle("Create Player");
        _username = valid.askQuestion("Please enter a username: ", 1);
        _players.forEach(element => {
            while (_username == element.UserName){
                _username = valid.askQuestion("It seems that username already exists\r\nPlease enter a username: ", 1);
            }
        });
        _type = valid.askQuestion("Are you a DM, or an Adventurer?: ", 1);
        while (!(_type.toLowerCase() == "dm" || _type.toLowerCase() == "adventurer")) {
            _type = valid.askQuestion("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
        }
        if (_type.toLowerCase() == "dm"){
            _campaign = valid.askQuestion("What is your campaign name?: ", 1);
            _partySize = valid.askForNumber("How many adventurers are in your campaign?: ", 1);
            _dm = new DM(_username, _campaign, _partySize);
            _players.push(_dm);
        }
        else{
            _charName = valid.askQuestion("What is your character's name?: ", 1);
            assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
            _charRace = valid.askQuestion("What is your character's race?: ", 1);
            assignment.selectRace(_charRace);
            assignment.mainMenu(["Rogue", "Bard", "Wizard", "Fighter"]);
            _charClass = valid.askQuestion("What is your character's class?: ", 1);
            assignment.selectClass(_charClass);
            _adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
            assignment.rollStats();
            _players.push(_adventurer);
        }
        assignment.mainMenu(items);
    }
    rollStats()
    {
        _adventurer = new Adventurer(_username, _charName, _charRace, _charClass);
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
        _adventurer.CharStats = stats;
    }
    characterList()
    {
        if (_players.length == 0){
            valid.displayMessage("You must first push a player");
            assignment.mainMenu();
        }
        else
        {
            _players.sort();
            console.clear();
            if (_removeChar == true)
            {
                menu.NewTitle("Remove Player");
                
            }
            else
            {
                menu.NewTitle("Display Character");
            }
            console.log();
            let x = 1;
            _players.push
            _players.forEach(element => {
                console.table(element)
                console.log(`[${x}]: `);
                util.Feedback(`${ "User Name:",-15}`, 3);           
                valid.displayMessage(` ${player.userName,-12}`, console.ForegroundColor = consoleColor.DarkMagenta);
                util.Feedback("Account Type:", 3);
                if (element === DM)
                {
                    util.Feedback(`${player.UserType,-12}\r\n`, 1);
                }
                else
                {
                    util.Feedback(`${player.UserType,-12}\r\n`, 2);
                }
                x++;
            });
            let info = valid.askForNumber("Which player you like more information on?: ");
            while (info < 1 || info > _players.Count)
            {
                info = valid.askForNumber(`Please choose a valid number between 1 and ${_players.Count}`);
            }
            info -= 1;
            if (_players[info] === Adventurer)
            {
                util.Feedback("Character Info\r\n", 3);
                console.log(`${"Name:",-14} ${players[info].CharName}`);
                console.log(`${"Race:", -14} ${players[info].Race}`);
                console.log(`${"Class:", -14} ${(Adventurer).Class}`);
                util.Feedback("Stats\r\n", 3);
                foreach(KeyValuePair<string,int> kvp in assignment._adventurer.CharStats)
                {
                    console.log(`${kvp.Key+":", -14} ${kvp.Value}`);
                }
                assignment._adventurer.CharStats.forEach(element => {
                    
                });
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
    removeCharacter()
    {
        console.clear();
        _removeChar = true;
        characterList();
        let remove = valid.askForNumber("Choose a player to remove.", 0);
        while (remove > _players.Count || remove < 1)
        {
            util.Feedback("No such player", 1);
            remove = valid.askForNumber("Choose a player to remove.", 0);
        }
        remove -= 1;
        util.Feedback(`${this.players[remove]._username} has been deleted\r\n`, 2);
        util.Feedback(`${_players[remove].UserName}: {_players[remove].Quit()}`, 1);
        _players.
        _players.RemoveAt(remove);
        Thread.Sleep(750);
        MainMenu();
    }
    createCharacter(event){
        event.preventDefault();
        name = document.getElementById("name").value;
        race = document.getElementById("races").value;
        classes = document.getElementById("classes").value;
        characters.push({ name: name, race: race, classes: classes });
        //COOKIE
        localStorage.setItem("characters", JSON.stringify(characters));
        console.table(characters);
        message = `${name}, the ${race} ${classes} has arrived. Welcome traveler!`;
        document.getElementById("your character").innerHTML = message;
        console.log(message);
        console.log(localStorage.storedCharacters);
    }
    diceRoll(event)
    {
        event.preventDefault();
        var die1 = document.getElementById("die1");
        var die2 = document.getElementById("die2");
        var status = document.getElementById("status");
        var d1 = Math.floor((Math.random() * 6) + 1);
        var d2 = Math.floor((Math.random() * 6) + 1);
        var diceTotal = d1 + d2;
        die1.innerHTML = d1;
        die2.innerHTML = d2;
        status.innerHTML = `You rolled ${diceTotal}.`;
    }
    viewCharacter(){
        console.table(storedCharacters);
        let stingArr = storedCharacters.split(",");
        stingArr.forEach(element => {
            element = element.replace("[", "");
            element = element.replace("]", "");
            element = element.replace("{", "");
            element = element.replace("}", "");
            console.log(element);
        });
    }
}
//LISTEN FOR EVENTS
let assignment =  new Assignment();
//assignment.mainMenu(items);

const startButton = document.getElementById("start");
if(startButton){
    console.log(startButton);
    startButton.addEventListener("click", assignment.startAll);
}
const createButton = document.getElementById("submitForm");
if(createButton){
    console.log(createButton);
    createButton.addEventListener("click", assignment.createCharacter);
  }
const rollButton = document.getElementById("rollDice");
if(rollButton){
    console.log(rollButton);
    rollButton.addEventListener("click", assignment.diceRoll);
}
const viewButton = document.getElementById("view")
if(viewButton){
    console.log(viewButton);
    viewButton.addEventListener("click", assignment.viewCharacter);
}