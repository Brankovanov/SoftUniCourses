let lines =["sf","sf","sf","sfdfds4","hgfh5","6fhfgh","7fghf","8gfh","9h","10hfh","Stop"];

function printLines(lines){

   for(let l of lines) {

        if (l !== "Stop"){

            console.log(l);
        }
        else{

            break;
        }
   }
}

printLines(lines);