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
function askForNumber(message) 
{
    let answer = prompt(message);
    console.log(message);
    while (!answer)
    {
        answer = prompt(message);
    }
    console.log(answer);
    return Number(answer);
}