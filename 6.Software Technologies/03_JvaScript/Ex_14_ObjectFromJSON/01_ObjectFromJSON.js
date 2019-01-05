let input =['{"name":"Gosho","age":10,"date":"19/06/2005"}','{"name":"Tosho","age":11,"date":"04/04/2005"}'];

function CreateObjectFromJSON(input) {

    let objectArr =[];

    for(let line of input){

        let entity =JSON.parse(line);
        objectArr.push(entity);
    }

    for(let entity of objectArr)
    {
        console.log("Name: " + entity.name);
        console.log("Age: " + entity.age);
        console.log("Date: " + entity.date);
    }
}

CreateObjectFromJSON(input);