let input =["1","2","3"];

function printer(input) {
    let index = input.length-1;

    for(let i =index; i>=0;i--){
        console.log(input[i]);
    }
}

printer(input);