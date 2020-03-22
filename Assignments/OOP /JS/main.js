function callAnimals()
{
let animal1 = new Animal("Cat");
console.log(animal1.makeNoise("meow"));

let dog1 = new Dog("beagle");
dog1.name = "Jean";
dog1.age = "15";
console.log(dog1.speak());
console.log(dog1.makeNoise());
dog1.hideBone("beagle")
}