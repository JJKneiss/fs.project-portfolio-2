console.log(alert("Welcome to Cookie Counter! \r\nToday we'll calculate profit made in buying packaged cookies, then selling them indivually."));
alert()
//User Prompt: Cookie Types
let cookiesRaw = prompt("First off, what types of cookies will you be buying? \r\nPlease separate each type with a comma.");

//Validate
while (!cookiesRaw || !(cookiesRaw.includes(",")))
{
    alert("Please Resubmit");
    cookiesRaw = prompt("First off, what types of cookies will you be buying? \r\nPlease separate each type with a comma.");
}

//Split: Array; Cookie Types.
let coookieArray = new Array(cookiesRaw.split(","));
for (let index = 0; index < cookieArray.Length; index++)
{
    cookieArray[i] = cookieArray[i].Trim();
}

//Create: Function Call
let cookieCall = [];
PromptCookieCosts(cookieArray);

//User Prompt: Cookie Number
Console.WriteLine("How many cookies are in each package?");
let packageNum = Console.ReadLine();

//Validate
while (isNaN(packageNum) || !packageNum)
{
    alert("Please Resubnit.") + console.log("Please Resubmit.");
    packageNum = Console.ReadLine();
}

//Find: Total Cookies
let total = packageNum * cookieArray.Length;

//User Prompt: Individual Cost
Console.WriteLine("What will you sell a single cookie for?");
let unitString = Console.ReadLine();

//Validate
while (isNaN(unitString))
{
    Console.WriteLine("Your response is not a price.");
    //User Promp: Individual Cost
    Console.WriteLine("Please resubmit your answer.");
    unitString = Console.ReadLine();
}

//Round: To 2
unitString = Math.round(unitString, 2);

//Create: Function Calls
let totalCall = TotalCookieCost(cookieCall);
let amountCall = AmountSoldFor(cookieCall, unitCost, packageNum);

//Find: Total Profit
let totalProfit = amountCall - totalCall;

//Round: To 2
totalProfit = Math.round(totalProfit, 2);

//Output: Final Answer
console.log(alert("You will make $"+totalProfit+", if you sell all "+cookieArray.Length+" cookie types" +
"asssuming each package of cookies contains "+total+" pieces for $"+unitCost+" per cookie."));
console.table({"Total Profit": totalProfit, "Piece Per Cost": unitCost})
//Create: Function
function PromptCookieCosts(cookieTypes)
{
    //Create: Array; Cookie Prices 
    let cookiePrice = new Array(cookieTypes.Length);

    //Create: Loop: Cookie Prices: User Input
    for (let index = 0; index<cookiePrice.Length; index++)
    {
        //User Prompt: Cookie Cost
        Console.WriteLine("What is the cost of the {0}.",cookieTypes[i]);
        let cookieCost = prompt("What is the cost of the {0}.",cookieTypes[i]);
        //Validate
        while (!cookieCost)
            {
                Console.WriteLine("Your response is not a price.");
                Console.WriteLine("Please resubmit your answer.");
                cookieString= Console.ReadLine();
            }
        //Add: To Array
        cookiePrice[i] = cookieCost;
    }
    //Return: To Main
    return cookiePrice;
}
//Create: Function
function TotalCookieCost(decimal[]cookiesMoar)
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
function AmountSoldFor (decimal[] cookieCall, unitPrice, packageTotal)
{
    //Calculate: Total Cookies
    let totalCookies = cookieCall.Length * packageTotal;
    //Calculate: Total Price
    let totalPrice = totalCookies * unitPrice;
    //Return: To Main
    return totalPrice;
}