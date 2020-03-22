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
        console.log(noise + ", I'm a " + this.species)
    }
}