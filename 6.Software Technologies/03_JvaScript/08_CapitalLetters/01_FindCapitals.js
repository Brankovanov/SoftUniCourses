let input =["We start by HTML, CSS, JavaScript, JSON and REST. Later we touch some PHP, MySQL and SQL. Later we play with C#, EF, SQL Server and ASP.NET MVC. Finally, we touch some Java, Hibernate and Spring.MVC."];

function findCapitals(input) {

    let result=[];

    for(let line of input) {

        let words = line.split(/\W+/);

        for (let word of words) {

            if (word.toUpperCase() === word && word!=="") {
                result.push(word);
            }
        }
    }

    return result.join(", ");
}

console.log(findCapitals(input));