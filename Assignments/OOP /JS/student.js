class Student extends Person
{ 
    constructor(name)
    {
        super(name);
        this.studentID = 123;
        this.grades = [];
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
        return Number (total / this.grades.length);
    }
}