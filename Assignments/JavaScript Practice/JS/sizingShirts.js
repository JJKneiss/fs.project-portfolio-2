function sizingShirts()
{
    let userAnswer = askQuestion("Hello! Welcome to Shirts R Us! What is your shirt size?" + 
        "\r\nSmall, Medium, Large, X-Large, XX-Large");
        userAnswer = userAnswer.toLowerCase();
        let shirtArray = ["xx-large", "medium", "large", "small", "xx-large", "small", "large", "xx-large", "large", "x-large", "medium", "medium"];
        
        let smallShirt = 0, 
            mediumShirt = 0, 
            largeShirt = 0, 
            xLargeShirt = 0, 
            xxLargeShirt = 0
        ;
        for (let index = 0; index < shirtArray.length; index++)
        {
            if (shirtArray[index] == "small")
            {
                smallShirt++;
            }
            else if (shirtArray[index] == "medium")
            {
                mediumShirt++;
            }
            else if (shirtArray[index] == "large")
            {
                largeShirt++;
            }
            else if (shirtArray[index] == "x-large")
            {
                xLargeShirt++;
            }
            else if (shirtArray[index] == "xx-large")
            {
                xxLargeShirt++;
            }
        }
    displayMessage("Your order will consist of: ");
    if (smallShirt== 1)
    {
        displayMessage(`${smallShirt} small shirt, `);
    }
    else if (smallShirt > 1)
    {
        displayMessage(`${smallShirt} small shirts, `);
    }
    if (mediumShirt == 1)
    {
        displayMessage(`${mediumShirt} medium shirt, `);
    }
    else if (mediumShirt > 1)
    {
        displayMessage(`${mediumShirt} medium shirts, `);
    }
    if (largeShirt == 1)
    {
        displayMessage(`${mediumShirt} large shirt, `);
    }
    else if (largeShirt > 1)
    {
        displayMessage(`${largeShirt} large shirts, `);
    }
    if (xLargeShirt == 1)
    {
        displayMessage(`${xLargeShirt} x-large shirt, `);
    }
    else if (xLargeShirt > 1)
    {
        displayMessage(`${xLargeShirt} x-large shirts, `);
    }
    if (xxLargeShirt == 1)
    {
        displayMessage(`${xxLargeShirt} xx-large shirt.`);
    }
    else if (xxLargeShirt > 1)
    {
        displayMessage(`${xxLargeShirt} xx-large shirts.`);
    }
}