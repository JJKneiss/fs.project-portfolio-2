function practiceArrays()
{
    let userName = askQuestion("What's your name?");
    let bookBuy = askQuestion("How many books are you buying?");
    //Create: Array
    let bookArray = [];
    let sum;
    //Create Loop
    for (let index = 0; index < bookBuy; index++)
    {
        //Prompt User: Book Price
        let bookCost = askQuestion("How much for this book?");
        //Validate
        
        while (!bookCost || isNaN(bookCost.trim('$')))
        {
            bookCost = askQuestion("How much for this book?");
        }
        //let cost = parseFloat(bookCost);
        sum += parseFloat(bookCost);
        //bookCost.trim('$');
        //bookArray[index] = bookCost;
        bookArray.push(parseFloat(bookCost));
    }
    //let sum;
    //Create Loop
    // for (let index = 0; index < bookArray.length; index++)
    // {
    //     sum = sum + bookArray[index];
    // }
    //     var sum = bookArray.reduce(function(a, b){
    //     return a + b;
    // }, 0);

    //sum = Math.round(sum, 2);
    if (bookBuy >= 2)
    {
        displayMessage(`Your total is ${sum} for ${bookArray.length} books.`);
    }
    else
    {
        displayMessage(`Your total is $${sum} for ${bookArray.length} book.`);
    }

    //Create Array
    let someThings = ["monitor", "computer", "desk", "keyboard", "mouse", "chair"];

    //Create Array
    let someColors = ["black", "gray", "brown", "green", "orange", "blue"];

    //Create Loop
    for (let index = 0; index < someColors.length; index++)
    {
        displayMessage(`The main color of the ${someThings[index]} is ${someColors[index]}.`);
    }
}