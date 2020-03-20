function countCookies()
{
    let cookieType = [], cookiePrice = [];
    displayMessage("Welcome to Cookie Counter! \r\nToday we'll calculate profit made in buying packaged cookies, then selling them indivually.");
    let cookies = askQuestion("What type of cookies will you be buying?");
    cookieType.push(cookies);
    let more = boolQuestion("Would you like to add another type?");
    while (more.toLowerCase() == "yes")
    {
        cookies = askQuestion("What type of cookies will you be buying?");
        cookieType.push(cookies);
        more = boolQuestion("Would you like to add another type?");
    }   
    cookieType.forEach(function(element)
    {
        let price = askForNumber(`What is the cost of the ${element} cookies?`);
        cookiePrice.push(price);
    });

    let reductions = 0;
    cookiePrice.forEach(function(element)
    {
        reductions += element;
    });

    //User Prompt: Cookie Number
    let packageSize = askForNumber("How many cookies are in each package?");
    //Find: Total Cookies
    let totalCookies = packageSize * cookieType.length;

    //User Prompt: Individual Cost
    let perUnit = askForNumber("What will you sell a single cookie for?");
    //Round: To 2
    perUnit = Math.round(perUnit, 2);

    let beforeSale = totalCookies * perUnit;
    let profit = beforeSale - reductions;

    //Round: To 2
    profit = Math.round(profit, 2);

    //Output: Final Answer
    displayMessage(`You will make $${profit}, if you sell all ${cookieType.length} cookie types, asssuming each package of cookies contains ${packageSize} pieces for $${perUnit} per cookie.`);
}
//TESTS
//Test 1
/*
    * Welcome to Cookie Counter!
    * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
    * First off, what types of cookies will you be buying?
    * Please separate each type with a comma.
    * Double Chocolate, Sugar, Snicker Doodle
    * What is the cost of cookie Double Chocolate.
    * 7.00
    * What is the cost of cookie Sugar.
    * 2.50
    * What is the cost of cookie Snicker Doodle.
    * 6.50
    * How many cookies are in each package?
    * 10
    * What will you sell a single cookie for?
    * 1
    * You will make $14.00, if you sell all 3 cookie types, asssuming each package of cookies contains 30 pieces for $1 per cookie.
    */
