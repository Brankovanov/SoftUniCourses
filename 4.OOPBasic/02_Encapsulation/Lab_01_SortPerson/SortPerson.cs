using System;
namespace Lab_01_SortPerson
{
    public class SortPerson
    {
        //Receives information from the console and creates newPerson object, creates a team and stores there the newPerson objects.
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var teamName = Console.ReadLine();
            var newTeam = new Team(teamName);

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                try
                {
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    newTeam.AddPlayer(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PrintPeople(newTeam);
        }

        //Prints the number of peoples in the first and reserve teams.
        public static void PrintPeople(Team newTeam)
        {
            Console.WriteLine($"First team have {newTeam.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {newTeam.ReserveTeam.Count} players");
        }
    }
}