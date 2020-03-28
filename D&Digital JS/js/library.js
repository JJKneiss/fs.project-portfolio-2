class Validation
{
    askQuestion(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(!answer)
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    stringsOnly(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(!answer || !isNaN(answer))
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    displayMessage(message)
    {
        alert(message);
        console.log(message);
    }
    askForNumber(message) 
    {
        let answer = prompt(message);
        console.log(message);
        while (!answer || isNaN(answer))
        {
            answer = Number(prompt(message));
        }
    
        console.log("%c" + answer, "color : green");
        return Number(answer);
    }
    boolQuestion(message)
    {
        let answer = prompt(message);
        console.log(message);
        while(answer.toLowerCase() != "yes" && answer.toLowerCase() != "no")
        {
            answer = prompt(message);
        }
        console.log("%c" + answer, "color : green");
        return String(answer);
    }
    screenClear()
    {
        let validation = new Validation();
        validation.displayMessage("Press Enter to Continue...");
        console.clear();
    }
}
class Menu
    {
        List<string> _items;

        Menu(params string[] items)
        {
            this.Title = "Main Menu";
            this.Divider = "===========================";
            _items = new List<string>();
            _items = items.ToList();
        }
        Formatting()
        {
            Utility.ChangeCyan(Title+"\r\n");
            console.log(Divider);
        }
        NewTitle(newTitle)
        {
            this.Title = newTitle;
            Formatting();
        }
        MinDisplay()
        {
            for (let i = 0; i < _items.Count; i++)
            {
                console.log(`[${i + 1}]: ${_items[i]}`);
            }
        }
        MaxDisplay()
        {
            Formatting();
            MinDisplay();
        }
    }
    class Utility
    {
        Continue(msg)
        {
            console.log(msg);
            console.ReadKey();
            console.Clear();
        }
        Welcome(msg)
        {
            displayMessage(msg);
            console.clear();
        }
        Goodbye(msg)
        {
            console.clear();
            console.log(msg);
        }
        Feedback(msg, color)
        {
            if(color == 1)
            {
                console.log("%"+ msg, "color:red");
            }
            else if (color == 2)
            {
                console.log("%"+ msg, "color:green");
            }
            else
            {
                console.log("%"+ msg, "color:yellow");
            }
        }
        ChangeCyan(msg)
        {
            console.log("%"+msg, "color:cyan");
        }
    }