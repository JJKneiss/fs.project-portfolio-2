function madLibs()
{
    displayMessage("Hello! Let's play a game of MadLibs, how's that sound?");
    displayMessage("\r\n(you don't have a choice here :3.)");
    
    let userName = askQuestion("Pease enter your name.");        
    let adjective = askQuestion("I'll need and adjective.");
    let animal = askQuestion("Please give me a type of animal!");
    let person = askQuestion("Now a name, just not your own.");
    let food = askQuestion("How about a food?");
    
    displayMessage("Please provide the following integers\r\n (press okay to continue.)");
    
    let cost = prompt("Cost");
    let year = prompt("Year");
    let num = prompt("Number");
    
    displayMessage("Ohhh boy... well this is... a story...");
    displayMessage(`One day, in the year ${year} a ${adjective} ${animal} ran around Wleter Park, coming across a biker named ${person}.` +
    ` The ${adjective} ${animal} began to sit next to the tired ${person}, but was soon chased off, as ${person} was allergic to ${animal}s.` +
    ` Throwing his ${cost} bag of ${food} at the ${animal} he soon realized he lost ${num} pieces of his ${food}.` +
    ` Saddened by this, he quietly sat contemplating quantum-mechanical theory and why ${food} is so tasty.`);

    displayMessage("Press Okay to Continue...");
    console.clear();
}

function askQuestion(message)
{
    let answer = prompt(message);
    console.log(message);
    while(!answer)
    {
        answer = prompt(message);
    }
    console.log(answer);
    return answer;
}
function displayMessage(message)
{
    alert(message);
    console.log(message);
}