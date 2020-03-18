
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
        let finalFood = foodTax + foodTotal;
        let totalTax = appleTax+ beefTax + nanaTax;
        
        let totalGrand = total + totalTax;
        totalGrand = Math.round(totalGrand.toFixed(2));
        displayMessage(`Excluding Tax; Bananas: $${totalNanas}, Beef Brisket: $${totalBeef}, Apple Pie: $${totalApples}. That all totals out to $${total}.`);
        displayMessage(`Including Tax; Bananas: ${finalNanas}, Beef Brisket: ${finalBeef}, Apple Pie: ${finalApples}. That sums $${totalTax} in taxes. Coming to a grand total of $${totalGrand}.`);
}
function promptCost(food)
{
        let foodPrice = askQuestion(`What is the price of a ${food}?`);
        let foodAmount = askQuestion(`How many ${food}s shall I get?`);
        let foodTotal = foodPrice * foodAmount;
        return foodTotal;
}
function promptTax(foodTotal)
{
        let foodTax = foodTotal * salesTax;
        return foodTax;
}
function promptTotal(foodTax)
{
        
}