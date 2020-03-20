function practiceLoops()
{
    let userName = askQuestion("Hey there, what's your name?");
    let currentBalance = askForNumber(`How much is in that piggy bank of yours, ${userName}?`);
    let addedFunds = askForNumber("How much is added each month?");
    let totalBalance = 0;
    for (let month = 1; month <= 12; month++)
    {
        totalBalance = currentBalance += addedFunds;
        if (month == 1 || month == 2 || month == 12)
        {
            if (month == 1)
            {
                displayMessage("Your total for this month is $" + totalBalance + ".");
            }
            else if (month == 2)
            {
                displayMessage("Your total for next month will be $" + totalBalance + ".");
            }
            else if (month == 12)
            {
                displayMessage("Your total after a year will be $" + totalBalance + ".");
            }
        }
        else
        {
            displayMessage("Your total for month " + month + " will be $" + totalBalance + ".");
        }
    }
    let timer = askForNumber(`Hey, ${userName}, what's the timer on the countdown, again?`);
    displayMessage("Blastoff in T-");
    while (timer > 0)
    {
        displayMessage(timer);
        timer--;
    }
    displayMessage("BLASTOFF");
    let remainder = askQuestion(`${userName} how many donuts are left?`);
    let wants = askQuestion("How many do you want?");

    while (wants > 3 || wants < 0)
    {
        if (wants > 3)
        {
            wants = displayMessage("Try less than four...");
        }
        else if (wants < 0)
        {
            wants = displayMessage("Nice try... I know you're on a diet but you can't give me donuts here.");
        }
    }
    //Calculate: Remaining Donuts
    remainder = remainder - wants;
    //Loop: While Remainder > 0, Prompt User
    while (remainder > 0)
    {
        displayMessage(`There are ${remainder} donuts left.`);
        let more = askQuestion("Want more?");
        while (more.toLowerCase() != "yes" && more.toLowerCase() != "no")
        {
            more = askQuestion("Yes or no, do you want more?");
        }
        if (more.toLowerCase() == "yes")
        {
            wants = askQuestion("How many?");           
        }
        else
        {
            wants = askQuestion("Too bad, we need to get rid of these. How many?");
        }
        remainder = remainder - wants;
    }
    if (remainder <= 0)
    {
        if (remainder < 0)
        {
            let owed = remainder * -2 / 2;
            if (owed == 1)
            {
                displayMessage("Okay so I'll owe you " + owed + " donut, then.");
            }              
            else
            {
                displayMessage("Okay so I'll owe you " + owed + " donuts, then.");
            }
        }
        else if (remainder == 0)
        {
            displayMessage("That's the last of the donuts. Enjoy!");
        }
    }
}