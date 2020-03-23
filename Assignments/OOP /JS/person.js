class Person 
{
    constructor(name)
    {
        this.age = 0;
        this.name = name;
    }
    speak()
    {
        return `My name is ${this.name}! I am ${this.age} years old!`;
    }
}