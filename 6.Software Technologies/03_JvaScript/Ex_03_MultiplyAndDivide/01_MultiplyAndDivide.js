let number =['15','3'];

function multiplyAndDivide(number){

    let numOne = Number(number[0]);
    let numTwo = Number(number[1]);
    let result=0;

    if(numTwo>=numOne){

       result = numOne*numTwo;
    }
    else{

       result=numOne/numTwo;
    }

    return result;
}

console.log(multiplyAndDivide(number));