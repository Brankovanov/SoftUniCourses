//let arr = ["8 15 7"];
function threeIntegerSum([arr]) {

let numbers = arr.split(' ');

if(Number(numbers[0])+Number(numbers[1])===Number(numbers[2])) {

    if(Number(numbers[0])<=Number(numbers[1])) {
        return numbers[0] + " + " + numbers[1] + " = " + numbers[2];
    }
    else{
        return numbers[1] + " + " + numbers[0] + " = " + numbers[2];
    }

}

else if (Number(numbers[1])+Number(numbers[2]) === Number(numbers[0])) {

    if(Number(numbers[1])<=Number(numbers[2])) {
        return numbers[1] + " + " + numbers[2] + " = " + numbers[0];
    }
    else{
        return numbers[2] + " + " + numbers[1] + " = " + numbers[0];
    }

}
else if (Number(numbers[0])+Number(numbers[2])===Number(numbers[1])) {

    if(Number(numbers[0])<=Number(numbers[2])) {
        return numbers[0] + " + " + numbers[2] + " = " + numbers[1];
    }
    else{
        return numbers[2] + " + " + numbers[0] + " = " + numbers[1];
    }

}
else {

    return "No";
}
}

//let result =threeIntegerSum(arr);
//console.log(result);

