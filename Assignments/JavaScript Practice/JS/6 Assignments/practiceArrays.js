//Set Divider
console.log("========================= ========================= =========================");
//Prompt User: Name
    let userName = prompt("What's your name?");
    
//Validate
while (!userName)
{
    alert("Please don't leave this blank.") + console.log("Please don't leave this blank.");
//User Prompt: Resubmit Name
    userName = prompt("What's your name, again?");
}
    alert(`Welcome ${userName}`) + console.log(`Welcome ${userName}`);
//Prompt User: Book Number
    let orderSize = prompt("How many books?");
//Validate
while (isNaN(orderSize) || !orderSize)
{
    orderSize = prompt("How many books?");
}
alert(`${orderSize} books have been added.`) + console.log(`${orderSize} books have been added.`);
//Create: Array   
    let bookCost;
    let sum;
    let bookArray = new Array(orderSize);
//Create Loop
for (let index = 0; index < orderSize; index++)
{
//Prompt User: Book Price
    bookCost = prompt("How much for this book?");
    for (let index = 0; index < orderSize; index++)
    {
        sum += bookArray[index];
    }
    bookArray.push(bookCost);
    //console.log("Book added.");
    console.table(bookArray)
//Validate
    while (isNaN(bookCost))
    {
        bookCost = prompt("What is the book's price/");
    }
}
//Create Loop
    
//Round: To 2
sum = Math.round(sum);

//Create Conditional
if (orderSize == 1)
{
    console.log(`Your total is $${sum} for ${orderSize} book.`);
}
else
{
    console.log(`Your total is $${sum} for ${orderSize} books.`);
}

//Set Divider
console.log("========================= ========================= =========================");

//Create Array
let someThings = [6];
someThings[0] = "monitor";
someThings[1] = "computer";
someThings[2] = "desk";
someThings[3] = "keyboard";
someThings[4] = "mouse";
someThings[5] = "chair";

//Create Array
let someColors = [6];
someColors[0] = "black";
someColors[1] = "gray";
someColors[2] = "brown";
someColors[3] = "green";
someColors[4] = "orange";
someColors[5] = "blue";

//Create Loop
for (let index = 0; index < someColors.Length; index++)
{
    console.log(`The main color of the ${someThings[index]} is ${someColors[index]}.`);
}