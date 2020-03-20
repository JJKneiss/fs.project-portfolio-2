function askQuestion(message)
{
    let answer = prompt(message);
    console.log(message);
    while(!answer)
    {
        answer = prompt(message);
    }
    console.log(answer);
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
    console.log(answer);
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

    console.log("%c" + answer, "color : red");
    return Number(answer);
}
function screenClear()
{
    displayMessage("Press Enter to Continue...");
    console.clear();
}