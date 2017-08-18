function StoringObj(info) {
    class Student {

        constructor(name, age, grade) {

            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    };

    let students = [];

    for (let i = 0; i < info.length; i++) {
        let temp = info[i].split(' -> ');
        let name = temp[0];
        let age = temp[1];
        let grade = temp[2];

        //students.push({Name:name, Age:age, Grade:grade});     // Array of objects
        students.push(new Student(name, age, grade));
    }
    for (let student of students)
    {
        console.log("Name: " + student.Name);
        console.log(`Age: ${student.Age}`);
        console.log(`Grade: ${student.Grade}`);

    }
}

StoringObj(['Pesho -> 13 -> 6.00','Ivan -> 12 -> 5.57','Toni -> 13 -> 4.90']);