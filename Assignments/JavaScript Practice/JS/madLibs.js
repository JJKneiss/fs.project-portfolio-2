
function madLibs()
{
    let validation = new Validation();
    validation.displayMessage("Hello! Let's play a game of MadLibs, how's that sound?");
    validation.displayMessage("\r\n(you don't have a choice here :3.)");
    
    let userName = validation.askQuestion("Pease enter your name.");        
    let adjective = validation.askQuestion("I'll need and adjective.");
    let animal = validation.askQuestion("Please give me a type of animal!");
    let person = validation.askQuestion("Now a name, just not your own.");
    let food = validation.askQuestion("How about a food?");
    
    validation.displayMessage("Please provide the following integers\r\n (press okay to continue.)");
    
    let cost = validation.askForNumber("Cost"), year = validation.askForNumber("Year"), num = validation.askForNumber("Number");

    validation.displayMessage("Ohhh boy... well this is... a story...");
    validation.displayMessage(`One day, in the year ${year} a ${adjective} ${animal} ran around Wleter Park, coming across a biker named ${person}.` +
    ` The ${adjective} ${animal} began to sit next to the tired ${person}, but was soon chased off, as ${person} was allergic to ${animal}s.` +
    ` Throwing his ${cost} bag of ${food} at the ${animal} he soon realized he lost ${num} pieces of his ${food}.` +
    ` Saddened by this, he quietly sat contemplating quantum-mechanical theory and why ${food} is so tasty.`);
    
    validation.screenClear();
}