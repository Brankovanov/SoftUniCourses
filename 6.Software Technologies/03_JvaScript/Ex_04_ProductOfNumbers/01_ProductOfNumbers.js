let number =['3','0','-1'];

function findProduct(number){
 let result ="Positive";
 let minuses =0;

    for(let num of number) {

        if (num < 0) {
            minuses++;
        } else if (num == 0) {
            minuses == 0;
            break;
        }
    }

    if(minuses%2!==0){
        result = "Negative";
    }

    return result;
}

console.log(findProduct(number));