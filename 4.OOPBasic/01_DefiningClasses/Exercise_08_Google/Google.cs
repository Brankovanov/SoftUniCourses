using System;
using System.Collections.Generic;

namespace Exercise_08_Google
{
    public class Google
    {
        public static void Main()
        {
            ReceiveInformation();
        }

        //Receives information from the console.
        public static void ReceiveInformation()
        {
            var personArchive = new List<Person>();
            var information = Console.ReadLine();

            while (information != "End")
            {
                SortInformation(information, personArchive);
                information = Console.ReadLine();
            }

            var query = Console.ReadLine();
            PrintQuery(query, personArchive);
        }

        //Sorts the received information.
        public static void SortInformation(string information, List<Person> personArchive)
        {
            var temp = information.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = temp[0];
            var dataCategory = temp[1];

            if (personArchive.Exists(p => p.Name == name))
            {
                Update(name, temp, personArchive, dataCategory);
            }
            else
            {
                Create(name, temp, personArchive, dataCategory);
            }
        }

        //Creates new person and records it.
        public static void Create(string name, string[] temp, List<Person> personArchive, string dataCategory)
        {
            var newPerson = new Person(name);
            personArchive.Add(newPerson);

            switch (dataCategory)
            {
                case "company":
                    UpdateCompany(name, temp, personArchive);
                    break;
                case "pokemon":
                    CreatePokemon(name, temp, personArchive);
                    break;
                case "parents":
                    CreateParents(name, temp, personArchive);
                    break;
                case "children":
                    CreateChildren(name, temp, personArchive);
                    break;
                case "car":
                    UpdateCar(name, temp, personArchive);
                    break;
            }
        }

        //Updates existing person.
        public static void Update(string name, string[] temp, List<Person> personArchive, string dataCategory)
        {
            switch (dataCategory)
            {
                case "company":
                    UpdateCompany(name, temp, personArchive);
                    break;

                case "pokemon":

                    if (personArchive.Find(p => p.Name == name).Pokemon != null)
                    {
                        UpdatePokemon(name, temp, personArchive);
                    }
                    else
                    {
                        CreatePokemon(name, temp, personArchive);
                    }

                    break;

                case "parents":

                    if (personArchive.Find(p => p.Name == name).Parent != null)
                    {
                        UpdateParents(name, temp, personArchive);
                    }
                    else
                    {
                        CreateParents(name, temp, personArchive);
                    }

                    break;

                case "children":

                    if (personArchive.Find(p => p.Name == name).Children != null)
                    {
                        UpdateChildren(name, temp, personArchive);
                    }
                    else
                    {
                        CreateChildren(name, temp, personArchive);
                    }

                    break;

                case "car":
                    UpdateCar(name, temp, personArchive);
                    break;
            }
        }

        //Creates and records the first pokemon in  person's collection.
        public static void CreatePokemon(string name, string[] temp, List<Person> personArchive)
        {
            var pokemonName = temp[2];
            var pokemonType = temp[3];
            var newPokemon = new Pokemon(pokemonName, pokemonType);
            personArchive.Find(p => p.Name == name).Pokemon = new List<Pokemon>();
            personArchive.Find(p => p.Name == name).Pokemon.Add(newPokemon);
        }

        //Updates the pokemon records  in  person's collection.
        public static void UpdatePokemon(string name, string[] temp, List<Person> personArchive)
        {
            var pokemonName = temp[2];
            var pokemonType = temp[3];
            var newPokemon = new Pokemon(pokemonName, pokemonType);
            personArchive.Find(p => p.Name == name).Pokemon.Add(newPokemon);
        }

        //Creates and records the first parent in  person's collection.
        public static void CreateParents(string name, string[] temp, List<Person> personArchive)
        {
            var parentName = temp[2];
            var parentBirthDay = temp[3];
            var newParent = new Parents(parentName, parentBirthDay);
            personArchive.Find(p => p.Name == name).Parent = new List<Parents>();
            personArchive.Find(p => p.Name == name).Parent.Add(newParent);
        }

        //Update parents' records in  person's collection.
        public static void UpdateParents(string name, string[] temp, List<Person> personArchive)
        {
            var parentName = temp[2];
            var parentBirthDay = temp[3];
            var newParent = new Parents(parentName, parentBirthDay);
            personArchive.Find(p => p.Name == name).Parent.Add(newParent);
        }

        //Creates and records the first children in  person's collection.
        public static void CreateChildren(string name, string[] temp, List<Person> personArchive)
        {
            var childName = temp[2];
            var childBirthDay = temp[3];
            var newChild = new Children(childName, childBirthDay);
            personArchive.Find(p => p.Name == name).Children = new List<Children>();
            personArchive.Find(p => p.Name == name).Children.Add(newChild);
        }

        //Updates children records in  person's collection.
        public static void UpdateChildren(string name, string[] temp, List<Person> personArchive)
        {
            var childName = temp[2];
            var childBirthDay = temp[3];
            var newChild = new Children(childName, childBirthDay);
            personArchive.Find(p => p.Name == name).Children.Add(newChild);
        }

        //Updates the company information.
        public static void UpdateCompany(string name, string[] temp, List<Person> personArchive)
        {
            var companyName = temp[2];
            var department = temp[3];
            var salary = double.Parse(temp[4]);
            var newCompany = new Company(companyName, department, salary);
            personArchive.Find(p => p.Name == name).Company = newCompany;
        }

        //Updates the cary information.
        public static void UpdateCar(string name, string[] temp, List<Person> personArchive)
        {
            var carModel = temp[2];
            var speed = int.Parse(temp[3]);
            var newCar = new Car(carModel, speed);
            personArchive.Find(p => p.Name == name).Automobile = newCar;
        }

        //Prints the information of the required person.
        public static void PrintQuery(string query, List<Person> personArchive)
        {
            Console.WriteLine(personArchive.Find(p => p.Name == query).Name);
            Console.WriteLine("Company:");

            if (personArchive.Find(p => p.Name == query).Company != null)
            {
                Console.WriteLine(personArchive.Find(p => p.Name == query).Company.CompanyName
                + " " + personArchive.Find(p => p.Name == query).Company.Department
               + " " + string.Format("{0:0.00}", personArchive.Find(p => p.Name == query).Company.Salary));
            }

            Console.WriteLine("Car:");

            if (personArchive.Find(p => p.Name == query).Automobile != null)
            {
                Console.WriteLine(personArchive.Find(p => p.Name == query).Automobile.CarModel
                + " " + personArchive.Find(p => p.Name == query).Automobile.CarSpeed);
            }

            Console.WriteLine("Pokemon:");

            if (personArchive.Find(p => p.Name == query).Pokemon != null)
            {
                foreach (var poke in personArchive.Find(p => p.Name == query).Pokemon)
                {
                    Console.WriteLine(poke.PokemonName + " " + poke.PokemonType);
                }
            }

            Console.WriteLine("Parents:");

            if (personArchive.Find(p => p.Name == query).Parent != null)
            {
                foreach (var pare in personArchive.Find(p => p.Name == query).Parent)
                {
                    Console.WriteLine(pare.ParentName + " " + pare.ParentBirthDay);
                }
            }

            Console.WriteLine("Children:");

            if (personArchive.Find(p => p.Name == query).Children != null)
            {
                foreach (var ch in personArchive.Find(p => p.Name == query).Children)
                {
                    Console.WriteLine(ch.ChildName + " " + ch.ChildBirthday);
                }
            }
        }
    }
}