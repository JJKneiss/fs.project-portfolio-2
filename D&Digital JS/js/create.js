//declare array
const characters = [];
//update array
function createCharacter(event){
    event.preventDefault();
    
    let name, race, classes, message;

    name = document.getElementById("name").value;
    race = document.getElementById("races").value;
    classes = document.getElementById("classes").value;
    characters.push({ name: name, race: race, classes: classes });
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