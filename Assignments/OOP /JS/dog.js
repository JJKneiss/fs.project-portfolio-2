class Dog extends Animal
{
    constructor(breed)
    {
        console.log("beagle Created");
        this.breed = breed;
    }
    getAvgGrade()
    {
        let total = 0;
        // For each Element in Grades, Run Function.
        this.grades.forEach(function(element)
        {
            total += element;
        });
        // for(let index = 0; index < this.grades.length; index++)
        // {
        //     total += this.grades[index];
        // }
        return total / this.grades.length;
    }
    hideBone()
    [
        
    ]
}