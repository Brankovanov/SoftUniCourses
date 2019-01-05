let input =["name -> Angel","surname -> Georgiev","age -> 20","grade -> 6.00","date -> 23/05/1995","town -> Sofia"];

function StringifyJSON(input) {

let str="{";
    for(let line of input){

        let temp = line.split(" -> ");
        let prop = temp[0];
        let value= temp[1];

        if(prop==="age" || prop==="grade"){
            str+='"'+prop+'":'+value+',';
        }
 else{
            str+='"'+prop+'":"'+value+'",';
        }



    }

str =str.substring(0,str.length-1);
    str+="}";
    let entity =JSON.parse(str);
        console.log(JSON.stringify(entity));

}

StringifyJSON(input);