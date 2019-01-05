let pairs = ["3 test","3 test1","4 test2","4 test3","4 test5","2"];

function CreateKeyValuePairs(pairs){

    let pairHolder = [];

    for(let line of pairs){
        let temp = line.split(' ');

        if(temp.length===2){

            let key = temp[0];
            let value = temp[1];

            pairHolder[key]=value;
        }
        else if(temp.length===1){

            if(pairHolder[line]!==undefined){
                console.log(pairHolder[line]);
            }
            else{
                console.log("None");
            }

        }
    }
}

CreateKeyValuePairs(pairs);