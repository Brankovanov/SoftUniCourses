let arrLenght =8;
let pairs = ["0 - 4", "1 - 5", "7 - 4", "0 - 1324" ];

function setPairs(arrLenght, pairs){

    let arr = [];

    for(let l=0;l<=arrLenght-1;l++){
        arr.push(Number(0));
    }

    for(let pair of pairs){
        let temp = pair.split(" - ");
        let key = Number(temp[0]);
        let value = Number(temp[1]);

        arr[key]=value;
    }

    for(let index =0;index<arrLenght;index++){
        if(arr[index]===undefined)
        {
            console.log(0);
        }
        else{
            console.log(arr[index]);
        }
    }
}

setPairs(arrLenght,pairs)