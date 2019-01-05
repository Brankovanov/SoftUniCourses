let input =["Pesho -> 13 -> 6.00","Ivan -> 12 -> 5.57","Toni -> 13 -> 4.90"];

function CreateObjectFromString(input) {

    let objectArr =[];

    for(let line of input){

        let temp = line.split(" -> ");
        let name = temp[0];
        let age = temp[1];
        let grade = temp[2];

        let entity ={name:name, age:age,grade:grade};
        objectArr.push(entity);
    }

    for(let entity of objectArr)
    {
        console.log("Name: " + entity.name);
        console.log("Age: " + entity.age);
        console.log("Grade: " + entity.grade);
    }
}

CreateObjectFromString(input);