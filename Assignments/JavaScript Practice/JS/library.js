function askQuestion(message)
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
function stringsOnly(message)
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
function displayMessage(message)
{
    alert(message);
    console.log(message);
}
function askForNumber(message) 
{
    let answer = prompt(message);
    console.log(message);
    while (!answer || isNaN(answer))
    {
        answer = prompt(message);
    }

    console.log("%c" + answer, "color : green");
    return Number(answer);
}
function boolQuestion(message)
{
    let answer = prompt(message);
    console.log(message);
    while(answer.LowerCase() != "yes" && answer.toLowerCase() != "no")
    {
        answer = prompt(message);
    }
    console.log("%c" + answer, "color : green");
    return String(answer);
}
function screenClear()
{
    displayMessage("Press Enter to Continue...");
    console.clear();
}