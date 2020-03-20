
function calculateGroceries()
{
        let userName = askQuestion("Hey there, what's your name?");

        let totalNanas = promptCost("banana");
        let totalBeef = promptCost("beef brisket");
        let totalApples = promptCost("apple");
        
        let salesTax = askQuestion("What's the sale's tax in this area? (as an integer,\r\n please)");
        salesTax /= 100;
        
        let taxNanas = promptTax(totalNanas);
        let taxBeef = promptTax(totalBeef);
        let taxApples = promptTax(totalApples);
        
        let total = totalNanas + totalBeef + totalApples;
        let tax = total * salesTax;
        let final = tax + total;
        
        displayMessage(`[Excluding Tax]: Bananas: $${totalNanas}, Beef Brisket: $${totalBeef}, Apple Pie: $${totalApples}. Total: $${total}.`);
        displayMessage(`[Including Tax]: Tax: ${tax}, Final Total: $${final}.`);
}
function promptCost(food)
{
let foodPrice = askQuestion(`What is the price of a ${food}?`);
let foodAmount = askQuestion(`How many ${food}s shall I get?`);
let foodTotal = foodPrice * foodAmount;
return foodTotal;
}
