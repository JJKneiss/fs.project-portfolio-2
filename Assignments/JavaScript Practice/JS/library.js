class Validation
{
    askQuestion(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(!answer)
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    stringsOnly(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(!answer || !isNaN(answer))
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    displayMessage(message)
    {
        alert(message);
        console.log(message);
    }
    askForNumber(message) 
    {
        let answer = prompt(message);
        console.log(message);
        while (!answer || isNaN(answer))
        {
            answer = Number(prompt(message));
        }
    
        console.log("%c" + answer, "color : green");
        return Number(answer);
    }
    boolQuestion(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(answer.toLowerCase() != "yes" && answer.toLowerCase() != "no")
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    screenClear()
    {
        let validation = new Validation();
        validation.displayMessage("Press Enter to Continue...");
        console.clear();
    }
}