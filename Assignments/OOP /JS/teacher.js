class Teacher extends Person
{
    constructor(name, course)
    {
        super(name);
        this.surname = "Walsh";
        this.course = course;
    }
    callAttendance(course, surname)
    {
        console.log("%cAlright, I'm going through attendance.", "color:cyan")
        this.course.forEach(function(element)
        {
            console.log(`%c${element.name}?`, "color:cyan");
            console.log(`%cHere, Mr. ${surname}`, "color:red");
        });
        console.log("%cAlright, thank you! Let's move on with class.", "color:cyan");
    }
}