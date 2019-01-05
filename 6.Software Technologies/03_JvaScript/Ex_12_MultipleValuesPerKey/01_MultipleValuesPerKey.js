let pairs = ["3 test","3 test1","4 test2","4 test3","4 test5","4"];

function MultipleValuesPerKey(pairs){

    let pairHolder = [];

    for(let line of pairs){
        let temp = line.split(' ');

        if(temp.length===2){

            let key = temp[0];
            let value = temp[1];

            if(pairHolder[key]===undefined){

                pairHolder[key]=[];
                pairHolder[key].push(value);
            }
            else{
                pairHolder[key].push(value);
            }
        }
        else if(temp.length===1){

            if(pairHolder[line]!==undefined){

                for(let entry of pairHolder[line]) {
                    console.log(entry);
                }
            }
            else{
                console.log("None");
            }

        }
    }
}

MultipleValuesPerKey(pairs);