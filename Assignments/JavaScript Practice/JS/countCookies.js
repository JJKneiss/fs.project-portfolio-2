function countCookies()
{
    let cookieType = [], cookiePrice = [];
    displayMessage("Welcome to Cookie Counter! \r\nToday we'll calculate profit made in buying packaged cookies, then selling them indivually.");
    let cookies = askQuestion("What type of cookies will you be buying?");
    cookieArray.push(cookies);
    let more = boolQuestion("Would you like to add another type?");
    while (more.toLowerCase() == "yes")
    {
        cookies = askQuestion("What type of cookies will you be buying?");
        cookieType.push(cookies);
        more = boolQuestion("Would you like to add another type?");
    }   
    cookieType.array.forEach(function(element)
    {
        let price = askForNumber(`What is the cost of the ${cookieTypes[element]} cookies?`);
        cookiePrice.push(price);
    });
    //User Prompt: Cookie Number
    let packageSize = askQuestion("How many cookies are in each package?");
    //Find: Total Cookies
    let total = packageSize * cookieType.length;
    //User Prompt: Individual Cost
    displayMessage("What will you sell a single cookie for?");
    let perUnit = askQuestion();
    //Round: To 2
    Math.round(perUnit, 2);
    //Create: Function Call
    let totalCall = TotalCookieCost(cookieCall);
    //Create: Function Call
    let amountCall = AmountSoldFor(cookieCall, unitCost, packageNum);
    //Find: Total Profit
    let totalProfit = amountCall - totalCall;
    //Round: To 2
    totalProfit = let.Round(totalProfit, 2);
    //Output: Final Answer
    displayMessage("You will make $"+totalProfit+", if you sell all "+cookieArray.Length+" cookie types, asssuming each package of cookies contains "+total+" pieces for $"+unitCost+" per cookie.");
}
//Create: Function
function TotalCookieCost(let[]cookiesMoar)
{
    let cookieFinal = 0;
//Create: Loop
    for (let i = 0; i < cookiesMoar.Length; i++)
    {
    //Calculate: Sum Packagages
        cookieFinal = cookiesMoar[i] + cookieFinal;
    }
//Return: To Main
    return cookieFinal;
}
//Create Function
function AmountSoldFor (let[] cookieCall, unitPrice, packageTotal)
{
//Calculate: Total Cookies
    let totalCookies = cookieCall.Length * packageTotal;
//Calculate: Total Price
    let totalPrice = totalCookies * unitPrice;
//Return: To Main
    return totalPrice;
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
//Test 2
/*
    * Welcome to Cookie Counter!
    * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
    * First off, what types of cookies will you be buying?
    * Please separate each type with a comma.
    * Mlet, Double Bubble  , Mystery
    * What is the cost of cookie Mlet.
    * 3.34567
    * What is the cost of cookie Double Bubble.
    * 2.2345
    * What is the cost of cookie Mystery.
    * 5.43
    * How many cookies are in each package?
    * 5
    * What will you sell a single cookie for?
    * 1
    * You will make $3.99, if you sell all 3 cookie types, asssuming each package of cookies contains 15 pieces for $1 per cookie.
    */
//Test 3
/*
    * Welcome to Cookie Counter!
    * Today we'll calculate profit made in buying packaged cookies, then selling them indivually.
    * First off, what types of cookies will you be buying?
    * Please separate each type with a comma.
    * ddas , sfadf  , adfad dsdf , adadf
    * What is the cost of the ddas.
    * 345.32234
    * What is the cost of the sfadf.
    * 6.43345678
    * What is the cost of the adfad dsdf.
    * 234567.8765432
    * What is the cost of the adadf.
    * 3.222
    * How many cookies are in each package?
    * 56
    * What will you sell a single cookie for?
    * 1223
    * You will make $39029.15, if you sell all 4 cookie types, asssuming each package of cookies contains 224 pieces for $1223 per cookie.
    */
