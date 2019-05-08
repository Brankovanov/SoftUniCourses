using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            ExecuteTasks();
        }

        public static void ExecuteTasks()
        {
            //SpeedRacing();
            //RawData();
            //CompanyRoster();
            //DateModifier();
            //PersonTasks();
            // Rectangle();
            //CarSalesman();
            //PokemonTrainer();
            Google();
        }

        public static void Google()
        {
            var information = Console.ReadLine();
            var personName = string.Empty;
            var command = string.Empty;
            var peopleArchive = new Dictionary<string, PersonFile>();

            while (information != "End")
            {
                var temp = information.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                personName = temp[0];
                command = temp[1];

                if (!peopleArchive.ContainsKey(personName))
                {
                    var person = new PersonFile();
                    peopleArchive.Add(personName, person);
                }

                switch (command)
                {
                    case "company":
                        var companyName = temp[2];
                        var companyDepartment = temp[3];
                        var salary = decimal.Parse(temp[4]);
                        peopleArchive[personName].Company.CompanyName = companyName;
                        peopleArchive[personName].Company.Department = companyDepartment;
                        peopleArchive[personName].Company.Salary = salary;
                        break;

                    case "pokemon":
                        var pokemonName = temp[2];
                        var pokemonType = temp[3];
                        peopleArchive[personName].PokemonArhive.Pokemons.Add(pokemonName, pokemonType);
                        break;

                    case "parents":
                        var parentName = temp[2];
                        var parentBirthday = temp[3];
                        peopleArchive[personName].Parent.Parent.Add(parentName, parentBirthday);
                        break;

                    case "children":
                        var childName = temp[2];
                        var childBirthday = temp[3];
                        peopleArchive[personName].Child.Child.Add(childName, childBirthday);
                        break;

                    case "car":
                        var carModel = temp[2];
                        var carSpeed = int.Parse(temp[3]);
                        peopleArchive[personName].Car.CarModel = carModel;
                        peopleArchive[personName].Car.CarSpeed = carSpeed;
                        break;
                }

                information = Console.ReadLine();
            }

            var informationRequest = Console.ReadLine();

            Console.WriteLine(peopleArchive[personName].Output(informationRequest));
        }

        public static void PokemonTrainer()
        {
            var information = Console.ReadLine();
            var trainerName = string.Empty;
            var pokemonName = string.Empty;
            var pokemonElement = string.Empty;
            var pokemonHealth = 0;
            var tournamentArchive = new Dictionary<string, Trainer>();

            while (information != "Tournament")
            {
                var temp = information.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                trainerName = temp[0];
                pokemonName = temp[1];
                pokemonElement = temp[2];
                pokemonHealth = int.Parse(temp[3]);

                if (tournamentArchive.ContainsKey(trainerName))
                {
                    var newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    tournamentArchive[trainerName].Pokemons.Add(newPokemon);
                }
                else
                {
                    var newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(newPokemon);
                    tournamentArchive.Add(trainerName, newTrainer);
                }


                information = Console.ReadLine();
            }

            var elements = Console.ReadLine();

            while (elements != "End")
            {
                foreach (var trainer in tournamentArchive)
                {
                    if (trainer.Value.Pokemons.Exists(p => p.Element == elements))
                    {
                        trainer.Value.NumberOfBadges++;

                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.Value.Pokemons.RemoveAll(p => p.Health <= 0);

                }
                elements = Console.ReadLine();
            }

            foreach (var trainer in tournamentArchive.OrderByDescending(b => b.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Key + " " + trainer.Value.NumberOfBadges + " " + trainer.Value.Pokemons.Count);
            }
        }

        public static void CarSalesman()
        {
            var model = string.Empty;
            var power = string.Empty;
            var displacement = string.Empty;
            var efficiency = string.Empty;
            var listOfEngines = new List<EngineForSale>();

            var numberOfEngines = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfEngines; index++)
            {
                var engineInput = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (engineInput.Length == 2)
                {
                    model = engineInput[0];
                    power = engineInput[1];
                    displacement = "n/a";
                    efficiency = "n/a";
                }
                else if (engineInput.Length == 3)
                {
                    if (int.TryParse(engineInput[2], out int r))
                    {
                        model = engineInput[0];
                        power = engineInput[1];
                        displacement = engineInput[2];
                        efficiency = "n/a";
                    }
                    else
                    {
                        model = engineInput[0];
                        power = engineInput[1];
                        displacement = "n/a";
                        efficiency = engineInput[2];
                    }

                }
                else if (engineInput.Length == 4)
                {
                    model = engineInput[0];
                    power = engineInput[1];
                    displacement = engineInput[2];
                    efficiency = engineInput[3];
                }

                var newEngine =
                    new EngineForSale(model, power, displacement, efficiency);

                listOfEngines.Add(newEngine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var carModel = string.Empty;
            var engine = string.Empty;
            var weight = string.Empty;
            var color = string.Empty;
            var listOfCars = new List<CarForSale>();

            for (var secondaryIndex = 1; secondaryIndex <= numberOfCars;
                secondaryIndex++)
            {
                var carInput = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (carInput.Length == 2)
                {
                    carModel = carInput[0];
                    engine = carInput[1];
                    weight = "n/a";
                    color = "n/a";
                }
                else if (carInput.Length == 3)
                {

                    carModel = carInput[0];
                    engine = carInput[1];

                    if (int.TryParse(carInput[2], out int n))
                    {
                        weight = carInput[2];
                        color = "n/a";
                    }
                    else
                    {
                        color = carInput[2];
                        weight = "n/a";
                    }

                }
                else if (carInput.Length == 4)
                {
                    carModel = carInput[0];
                    engine = carInput[1];
                    weight = carInput[2];
                    color = carInput[3];
                }

                var carForSale = new CarForSale(carModel, listOfEngines
                    .Find(em => em.Model == engine), weight, color);
                listOfCars.Add(carForSale);
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine(car.CarSpecifics());
            }
        }

        public static void Rectangle()
        {
            var listOfRectangles = new List<Rectangle>();
            var input = Console.ReadLine().Split(' ');
            var numberOfRectangles = double.Parse(input[0]);
            var numerOfIntercectionChecks = double.Parse(input[1]);

            for (var index = 1; index <= numberOfRectangles; index++)
            {
                var rectangle = Console.ReadLine().Split(' ').ToList();
                var id = rectangle[0];
                var width = double.Parse(rectangle[1]);
                var height = double.Parse(rectangle[2]);
                var topLeftHorizontal = double.Parse(rectangle[3]);
                var topLeftVertical = double.Parse(rectangle[4]);

                var newRectangle = new Rectangle(id, width, height, topLeftHorizontal, topLeftVertical);
                listOfRectangles.Add(newRectangle);
            }

            for (var secondIndex = 1; secondIndex <= numerOfIntercectionChecks; secondIndex++)
            {
                var pair = Console.ReadLine().Split(' ');
                var first = pair[0];
                var second = pair[1];

                Console.WriteLine(listOfRectangles.Find(r => r.Id == first).CheckForIntersections(listOfRectangles.Find(r => r.Id == second)));
            }
        }

        public static void PersonTasks()
        {
            var number = int.Parse(Console.ReadLine());
            var family = new Family();

            for (var n = 1; n <= number; n++)
            {
                var input = Console.ReadLine();
                var temp = input.Split(' ');
                var name = temp[0];
                var age = int.Parse(temp[1]);

                var newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }

            FindOldestMember(family);
            AgeFilter(family);
        }

        public static void DateModifier()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            CalculateDateDifference(firstDate, secondDate);
        }

        public static void CompanyRoster()
        {
            var numberOfEmploeeys = int.Parse(Console.ReadLine());
            var emploeeyInformation = string.Empty;
            var name = string.Empty;
            var salary = 0m;
            var position = string.Empty;
            var department = string.Empty;
            var email = string.Empty;
            var age = 0;
            var departmentList = new Department();

            for (var index = 1; index <= numberOfEmploeeys; index++)
            {
                emploeeyInformation = Console.ReadLine();
                var temp = emploeeyInformation.Split(' ');
                name = temp[0];
                salary = decimal.Parse(temp[1]);
                position = temp[2];
                department = temp[3];
                age = -1;
                email = "n/a";

                if (temp.Length == 5)
                {
                    if (temp[4].Contains("@"))
                    {
                        email = temp[4];
                    }
                    else
                    {
                        age = int.Parse(temp[4]);
                    }
                }
                if (temp.Length == 6)
                {
                    age = int.Parse(temp[5]);
                    email = temp[4];
                }

                var employee = new Employee(name, salary, position, department, email, age);
                CreateDepartments(employee, departmentList);
            }

            CalculateHighestDepartment(departmentList);
        }

        public static void SpeedRacing()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var carArchive = new Dictionary<string, Car>();

            for (var index = 1; index <= numberOfCars; index++)
            {
                var car = Console.ReadLine();
                var carSpecifics = car.Split(' ');
                var carModel = carSpecifics[0];
                var fuelAmount = double.Parse(carSpecifics[1]);
                var fuelConsumption = double.Parse(carSpecifics[2]);

                if (!carArchive.ContainsKey(carModel))
                {
                    var newCar = new Car(carModel, fuelAmount, fuelConsumption);
                    carArchive.Add(carModel, newCar);
                }
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("Drive"))
                {
                    var temp = command.Split(' ');
                    var model = temp[1];
                    var distance = double.Parse(temp[2]);
                    carArchive[model].Drive(distance);
                }

                command = Console.ReadLine();
            }

            foreach (var car in carArchive)
            {
                Console.WriteLine(car.Value.Model + " " + String.Format("{0:0.00}", car.Value.FuelAmount) + " " + car.Value.TraveledDistance);
            }
        }

        public static void RawData()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var listOfCargoCars = new List<CargoCar>();

            for (var index = 1; index <= numberOfCars; index++)
            {
                var cargoCar = Console.ReadLine();
                var information = cargoCar.Split(' ');
                var model = information[0];
                var engineSpeed = int.Parse(information[1]);
                var enginePower = int.Parse(information[2]);
                var cargoWeight = int.Parse(information[3]);
                var cargoType = information[4];
                var tireOnePressure = double.Parse(information[5]);
                var tireOneAge = int.Parse(information[6]);
                var tireTwoPressure = double.Parse(information[7]);
                var tireTwoAge = int.Parse(information[8]);
                var tireTreePressure = double.Parse(information[9]);
                var tireTreeAge = int.Parse(information[10]);
                var tireFourPressure = double.Parse(information[11]);
                var tireFourAge = int.Parse(information[12]);

                var newCargoCar = new CargoCar(model, enginePower, engineSpeed, cargoWeight, cargoType,
                    tireOneAge, tireOnePressure, tireTwoAge, tireTwoPressure, tireTreeAge, tireTreePressure,
                    tireFourAge, tireFourPressure);

                listOfCargoCars.Add(newCargoCar);
            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    foreach (var car in listOfCargoCars.Where(c => c.Cargo.Type == "fragile")
                        .Where(t => t.Tires.TireOnePressure < 1 || t.Tires.TireTwoPressure < 1
                        || t.Tires.TireTreePressure < 1 || t.Tires.TireFourPressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;

                case "flamable":
                    foreach (var car in listOfCargoCars.Where(c => c.Cargo.Type == "flamable")
                       .Where(e => e.Engine.EnginePower > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }
        }

        public static void CalculateHighestDepartment
            (Department departmentList)
        {
            Console.WriteLine(departmentList.CalculateIncome());
        }

        public static void CreateDepartments
            (Employee employee, Department departmentList)
        {
            if (departmentList.Departments.ContainsKey(employee.Department))
            {
                departmentList.Departments[employee.Department].Add(employee);
            }
            else
            {
                departmentList.Departments.Add(employee.Department, new List<Employee>());
                departmentList.Departments[employee.Department].Add(employee);
            }
        }

        public static void FindOldestMember(Family family)
        {
            Console.WriteLine(family.GetOldestMember().Name +
                " " + family.GetOldestMember().Age);
        }

        public static void AgeFilter(Family family)
        {
            Console.WriteLine(family.AgeFilter());
        }

        public static void CalculateDateDifference
            (string firstDate, string secondDate)
        {
            var dateModifier = new DateModifier(firstDate, secondDate);
            Console.WriteLine(dateModifier.CalculateDifference());
        }
    }
}