const characters = [];
let storedCharacters = null;

let adventurer, dm;
let username, type;
let campaign, partySize;
let charName, charRace, charClass;
let players = [], items = ["Create User", "View User", "Roll Dice", "Exit"];
let valid = new Validation(), util = new Utility(), menu = new Menu(items);

class Assignment{
    constructor(){}

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
                assignment.diceRoller();                    
                break;
            case "3":
                util.Goodbye("Goodbye");
                break;
            default:
                valid.displayMessage("invalid option, please resubmit")
                assignment.mainMenu(items);
                assignment.select();
                break;
        }
    }

    selectRace(race)
    {
        switch (race)
        {
            case "human":
            case "Human":
            case "0":
                race = "Human";
                break;
            case "elf":
            case "Elf":
            case "1":
                race = "Elf";
                break;
            case "dwarf":
            case "Dwarf":
            case "2":
                race = "Dwarf";
                break;
            case "orc":
            case "Orc":
            case "3":
                race = "Orc";
                break;
            default:
                let  race = valid.askQuestion("invalid option, please resubmit")
                assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
                assignment.selectClass(race);
                break;
        }
        return race;
    }

    selectClass(classChoice)
        {
            switch (classChoice)
            {
                case "rogue":
                case "Rogue":
                case "0":
                    classChoice = "Rogue";
                    break;
                case "bard":
                case "Bard":
                case "1":
                    classChoice = "Bard";
                    break;
                case "wizard":
                case "Wizard":
                case "2":
                    classChoice = "Wizard";
                    break;
                case "fighter":
                case "Fighter":
                case "3":
                    classChoice = "Fighter";
                    break;
                default:
                    let classChoice = valid.askQuestion("invalid option, please resubmit")
                    assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
                    assignment.selectClass(classChoice);
                    break;
            }
            return cClass;
    }
    selectDice(type, number)
    {
        // Set Total
        let total = 0;
        // Roll Dice According to Provided Amount & Type
        switch (type)
        {
            case "0":
            case "d4":
                case "D4":
                total = assignment.DiceRoll(4, number);
                valid.displayMessage("You rolled a total of: " + total);
                break;
            case "1":
            case "d6":
                case "D6":
                total = assignment.DiceRoll(6, number);
                case "2":
            case "d8":
                case "D8":
                total = assignment.DiceRoll(8, number);
                valid.displayMessage("You rolled a total of: " + total);
                break;
            case "3":
            case "d10":
                case "D10":
                total = assignment.DiceRoll(10, number);
                valid.displayMessage("You rolled a total of: " + total);
                break;
            case "4":
            case "d12":
                case "D12":
                total = assignment.DiceRoll(12, number);
                valid.displayMessage("You rolled a total of: " + total);
                break;
            case "5":
            case "d20":
                case "D20":
                total = dice.DiceRoll(20, number);
                valid.displayMessage("You rolled a total of: " + total);
                break;
            default:
                let dice = valid.askQuestion("invalid option, please resubmit")
                assignment.mainMenu();
                assignment.selectClass(dice);
                break;
        }
    }

    createPlayer()
    {    
        console.clear();
        menu.NewTitle("Create Player");
        username = valid.askQuestion("Please enter a username: ", 1);
        players.forEach(element => {
            while (username == element.UserName){
                username = valid.askQuestion("It seems that username already exists\r\nPlease enter a username: ", 1);
            }
        });
        type = valid.askQuestion("Are you a DM, or an Adventurer?: ", 1);
        while (!(type.toLowerCase() == "dm" || type.toLowerCase() == "adventurer")) {
            type = valid.askQuestion("I'm sorry, that wasn't right. Please choose a type: DM or Adventurer: ", 1);
        }
        if (type.toLowerCase() == "dm"){
            campaign = valid.askQuestion("What is your campaign name?: ", 1);
            partySize = valid.askForNumber("How many adventurers are in your campaign?: ", 1);
            dm = new DM(username, campaign, partySize);
            players.push({ Username: username, "Campaign Name": campaign, "Party Size" : partySize});
        }
        else{
            charName = valid.askQuestion("What is your character's name?: ", 1);
            assignment.mainMenu(["Human", "Elf", "Dwarf", "Orc"]);
            charRace = valid.askQuestion("What is your character's race?: ", 1);
            assignment.selectRace(charRace);
            assignment.mainMenu(["Rogue", "Bard", "Wizard", "Fighter"]);
            charClass = valid.askQuestion("What is your character's class?: ", 1);
            assignment.selectClass(charClass);
            adventurer = new Adventurer(username, charName, charRace, charClass);
            assignment.rollStats();
            players.push({ Username: username, "Character Name": charName, Race : charRace, Class: charClass });
        }
        assignment.saveData();
        assignment.mainMenu(items);
        assignment.select();
    }
    
    rollStats()
    {
        adventurer = new Adventurer(username, charName, charRace, charClass);
        console.log("Let's roll your stats.");
        let stats = [];
        let strength = assignment.rollDice(6, 1);        
        stats.push(strength);
        let dexterity = assignment.rollDice(6, 1);
        stats.push(dexterity);
        let constitution = assignment.rollDice(6, 1);
        stats.push(constitution);
        let wisdom = assignment.rollDice(6, 1);
        stats.push(wisdom);
        let intelligence = assignment.rollDice(6, 1);
        stats.push(intelligence);
        let charisma = assignment.rollDice(6, 1);
        stats.push(charisma);
        adventurer.CharStats = stats;
        console.log(adventurer.userName);
    }

    characterList()
    {
        if (storedCharacters == null){
            valid.displayMessage("You must first push a player");
            assignment.mainMenu();
        }
        else
        {
            players.sort();
            console.clear();
            menu.NewTitle("Display Character");
            players.push
            players.forEach(element => {
                console.table(element)
            });         
        }
        valid.displayMessage("Press Enter to Continue")
        assignment.mainMenu(items);
        assignment.select();
    } 

    diceRoller()
        {
            // Clear & Set Title 
            console.clear();
            menu.NewTitle("Roll Dice");
            // Prompt Amount of Dice
            let number = valid.askForNumber("How many dice will you be rolling here?", 2);
            // Validate Between 1 & 9
            while (number > 9 || number < 1)
            {
                if (number > 9)
                {
                    number = valid.askForNumber("Try rolling less than 10 dice: ", 2);
                }
                else
                {
                    number = valid.askForNumber("Try rolling more than than 0 dice: ", 2);
                }
            }
            // Display Dice Options
            console.log("Types\r\n");
            assignment.mainMenu(["D4", "D6", "D8", "D10", "D12", "D20"]);
            // Prompt Dice Type
            let type = valid.askQuestion("Which dice type would you like to use?", 2);
            assignment.selectDice(type, number);
            assignment.mainMenu(items);
            assignment.select();
        }
        rollDice(sides, number)
        {
            let total = 0;
            let roll = 0;
            // Roll X amount of Y Sided Dice.
            for (let i = 0; i < number; i++)
            {
                // Find Roll
                roll = Math.floor((Math.random() * sides) + 1);
                console.log("You rolled a " + roll);
                // Add Roll to Total
                total += roll;
            }
            return total;
        }
    saveData(){
        storedCharacters = localStorage.getItem("characters");
        localStorage.setItem("characters", JSON.stringify(players));
    }
}
class DOMStuff{
    // Begin Console Project
    startAll(event){
        event.preventDefault();
        // Add Array items to Menu
        assignment.mainMenu(items);
        // Prompt Selection
        assignment.select();
    }
    // Create Character
    createCharacter(event){
        event.preventDefault();
        // Pull User Input from Form
        let name = document.getElementById("name").value;
        let race = document.getElementById("races").value;
        let classes = document.getElementById("classes").value;
        // Push to Array
        players.push({ name: name, race: race, classes: classes });
        //COOKIE
        assignment.saveData();
        // Display Character Array in Console
        console.table(players);
        // Confirm Creation in DOM
        let message = `${name}, the ${race} ${classes} has arrived. Welcome traveler!`;
        document.getElementById("your character").innerHTML = message;
        // Display Confirmation & Storage in Console
        console.log(message);
    }

    viewCharacter(event){
        event.preventDefault();
        let stingArr = storedCharacters.split(",");
        stingArr.forEach(element => {
            element = element.replace("[", "");
            element = element.replace("]", "");
            element = element.replace("{", "");
            element = element.replace("}", "");
            console.log(element);
        });
    }

    diceRoll(event)
    {
        event.preventDefault();
        // Assign Values
        var die1 = document.getElementById("die1");
        var die2 = document.getElementById("die2");
        var status = document.getElementById("status");
        // Roll Random Number (1-6)
        var d1 = Math.floor((Math.random() * 6) + 1);
        var d2 = Math.floor((Math.random() * 6) + 1);
        // Sum Rolls
        var diceTotal = d1 + d2;
        die1.innerHTML = d1;
        die2.innerHTML = d2;
        // Display in DOM
        status.innerHTML = `You rolled ${diceTotal}.`;
    }
}
//LISTEN FOR EVENTS
let assignment =  new Assignment();
let domStuff = new DOMStuff();

// Listen for Console Start Click
const startButton = document.getElementById("start");
if(startButton){
    console.log(startButton);
    startButton.addEventListener("click", domStuff.startAll);
}
// Listen for Character Submission Click
const createButton = document.getElementById("submitForm");
if(createButton){
    console.log(createButton);
    createButton.addEventListener("click", domStuff.createCharacter);
  }
// Listen for Dice Roll Click
const rollButton = document.getElementById("rollDice");
if(rollButton){
    console.log(rollButton);
    rollButton.addEventListener("click", domStuff.diceRoll);
}
// Listen for View Characters Click
const viewButton = document.getElementById("view")
if(viewButton){
    console.log(viewButton);
    viewButton.addEventListener("click", domStuff.viewCharacter);
}