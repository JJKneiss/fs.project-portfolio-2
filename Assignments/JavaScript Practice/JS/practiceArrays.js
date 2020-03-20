function practiceArrays()
{
    let userName = askQuestion("What's your name?");
    let bookBuy = askForNumber("How many books are you buying?");
    while(bookBuy <= 0)
    {
        bookBuy = askForNumber("How many books are you buying?");
    }
    //Create: Array
    let bookArray = [];
    let sum = 0;
    let bookCost;
    //Create Loop
    for (let index = 0; index < bookBuy; index++)
    {
        //Prompt User: Book Price
        bookCost = askForNumber("How much for this book?");
        bookArray.push(bookCost);
    }   
    bookArray.forEach(function(e)
    {
        sum += e;
    });
    if (bookBuy > 1)
    {
        displayMessage(`Your total is ${sum} for ${bookArray.length} books.`);
    }
    else
    {
        displayMessage(`Your total is $${sum} for ${bookArray.length} book.`);
    }
    screenClear();
    //Create Array
    let someThings = ["monitor", "computer", "desk", "keyboard", "mouse", "chair"];

    //Create Array
    let someColors = ["black", "gray", "brown", "green", "orange", "blue"];
    //Create Loop
    for (let index = 0; index < someColors.length; index++)
    {
        displayMessage(`%cThe main color of the ${someThings[index]} is ${someColors[index]}.`);
    }
}