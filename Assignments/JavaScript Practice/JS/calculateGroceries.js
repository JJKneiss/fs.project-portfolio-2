
function calculateGroceries()
{
        let userName = askQuestion("Hey there, what's your name?");

        let totalNanas = promptCost("banana");
        let totalBeef = promptCost("beef brisket");
        let totalApples = promptCost("apple");
        
        let salesTax = askQuestion("What's the sale's tax in this area? (as an integer,\r\n please)");
        salesTax /= 100;
        
        let finalNanas = promptTax(totalNanas);
        let finalBeef = promptTax(totalBeef);
        let finalApples = promptTax(totalApples);
        
        let total = totalNanas + totalBeef + totalApples;
        let totalTax = appleTax+ beefTax + nanaTax;
        
        let totalGrand = total + totalTax;
        totalGrand = Math.round(totalGrand.toFixed(2));
        let finalMessage = 
        alert(`Excluding Tax; Bananas: $${totalNanas}, Beef Brisket: $${totalBeef}, Apple Pie: $${totalApples}. That all totals out to $${total}.`);
        alert(`Including Tax; Bananas: ${finalNanas}, Beef Brisket: ${finalBeef}, Apple Pie: ${finalApples}. That sums $${totalTax} in taxes. Coming to a grand total of $${totalGrand}.`);
}

function askQuestion(message)
{
        let answer = prompt(message);
        console.log(message);
        while(!answer)
        {
        answer = prompt(message);
        }
        console.log(answer);
        return answer;
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
        let finalFood = foodTax + foodTotal;
        return finalFood;
}
