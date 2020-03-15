//declare array
const characters = [];
//update array
function createCharacter(event){
    event.preventDefault();
    
    let n, r, c, message;


    n = document.getElementById("name").value;
    r = document.getElementById("races").value;
    c = document.getElementById("classes").value;
    characters.push({ name: n, race: r, classes: c });
    //COOKIE
    localStorage.setItem("characters", JSON.stringify(characters));
    console.table(characters);
    message = `${n}, the ${r} ${c} has arrived. Welcome traveler!`;
    document.getElementById("your character").innerHTML = message;
    console.log(message);
    console.log(localStorage.characters);
}
//LISTEN FOR EVENTS
const myButton = document.getElementById("submitForm");
console.log(myButton);
myButton.addEventListener("click", createCharacter);