let course = [];

let person1 = new Person("Jim");
person1.age = 40;
console.log(person1.speak());

let student1 = new Student("Jamie");
student1.age = 20;
student1.grades = [70, 80, 90];

course.push(student1);
console.log(student1.speak());

let student2 = new Student("Jean");
student2.age = "24";
student2.grades = [90, 80, 80];
course.push(student2);
console.log(student2.speak());

let teacher1 = new Teacher("John");
teacher1.course = course;
console.log(teacher1.callAttendance(course, teacher1.surname));

course.forEach(function(element)
{
    console.log(`${element.name}, your average is ${element.getAvgGrade()}`);
})