let numbers =[123,34,234,345,234,234,123,2354];

function sortAndPrint(numbers){

    let parsed =numbers.map(Number);
    parsed.sort((a,b)=>b-a);
    let indexBorder=Math.min(3,parsed.length);

    for(let index=0; index<indexBorder;index++){
        console.log(parsed[index]);
    }
}

sortAndPrint(numbers);