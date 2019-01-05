let commands = ["add 3","add 5","remove 2","remove 0","add 7"];

function ExecuteCommands(commands){
    let finalArr =[];

    for(let pair of commands){
        let temp = pair.split(' ');
        let command = temp[0];
        let value = Number(temp[1]);

        if (command==="add"){
            finalArr.push(value);
        }
        else if (command==="remove"){
            finalArr.splice(value,1);
        }
    }

    for(let line of finalArr)
    {
        console.log(line);
    }
}

ExecuteCommands(commands);