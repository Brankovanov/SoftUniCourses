function iterate(){
    let input =["1000"];
    let result="";

    for(let index=1; index<Number(input[0]); index++)
    {
        if(isSymmetric(index.toString())){
            result+=index+" ";
        }
    }

    return result;
}

function isSymmetric(index){
    for(let i=0; i<index.length/2;i++) {
        if (index[i] !== index[index.length - i - 1]) {
            return false;
        }
    }
    return true;
}

console.log(iterate());