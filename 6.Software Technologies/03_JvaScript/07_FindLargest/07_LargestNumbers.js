let numbers=[10,30];

function findLargest(numbers){

    let largest=[];
    let parsed = numbers.map(Number);

    for(let index =0;index<3;index++){

        if(parsed.length>=1) {
            let bigNum = Math.max(...parsed)
            largest.push(bigNum);
            parsed.splice(parsed.indexOf(bigNum), 1);
        }
    }

    for(let s of largest){
        console.log(s+ " ");
    }
}

findLargest(numbers);