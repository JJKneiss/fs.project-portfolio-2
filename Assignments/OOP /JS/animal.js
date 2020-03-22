class Animal
{
    constructor(species)
    {
        console.log("Person Created.");
        this.age = 2;
        this.species = species;
    }
    makeNoise(noise)
    {
        displayMessage(noise + ", I'm a " + this.species)
    }
}