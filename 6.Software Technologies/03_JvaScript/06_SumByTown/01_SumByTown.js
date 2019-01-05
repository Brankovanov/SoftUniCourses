let incomeByTown=[];

function createTown() {
    let input = ['{"town":"Sofia","income":200}','{"town":"Varna","income":120}','{"town":"Pleven","income":60}','{"town":"Varna","income":70}'];
    let towns = input.map(o=>JSON.parse(o));
    return towns;
}

function calculateIncome(){
    for( let obj of createTown()) {
        let name = obj.town.toString();

        if ( incomeByTown[0]!==undefined && incomeByTown.some(n=>n.town===name)){
         incomeByTown[incomeByTown.findIndex(e=>e.town===name)].income+=obj.income;
        }
        else{
            incomeByTown.push(obj);
        }
    }

    return incomeByTown;
}

function print() {

    let sorted = calculateIncome().map(JSON.stringify).sort().map(o=>JSON.parse(o));

    for(let t of sorted) {
         console.log(t.town + " -> " + t.income);
    }
}

print();