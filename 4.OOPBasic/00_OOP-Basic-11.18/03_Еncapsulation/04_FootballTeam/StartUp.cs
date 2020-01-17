using System;
using System.Collections.Generic;

namespace _04_FootballTeam
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var legue = new List<Team>();
            var command = Console.ReadLine();


            while (command != "END")
            {

                var temp = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var type = temp[0];

                switch (type)
                {
                    case "Team":
                        CreateTeam(temp, legue);
                        break;
                    case "Add":
                        AddPlayer(temp, legue);
                        break;
                    case "Remove":
                        RemovePlayer(temp, legue);
                        break;
                    case "Rating":
                        CalculateRating(temp, legue);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }

        public static void CreateTeam(string[] temp, List<Team> legue)
        {
            try
            {
                var teamName = temp[1];

                var newTeam = new Team(teamName);
                legue.Add(newTeam);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddPlayer(string[] temp, List<Team> legue)
        {
            var teamName = temp[1];
            var playerName = temp[2];
            var endurance = double.Parse(temp[3]);
            var sprint = double.Parse(temp[4]);
            var dribble = double.Parse(temp[5]);
            var passing = double.Parse(temp[6]);
            var shooting = double.Parse(temp[7]);

            try
            {
                var newPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                if (legue.Exists(n => n.Name.Equals(teamName)))
                {
                    legue.Find(n => n.Name.Equals(teamName)).AddPlayer(newPlayer);
                }
                else
                {
                    Console.WriteLine($"Team{teamName} does not exist.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void RemovePlayer(string[] temp, List<Team> legue)
        {
            var teamName = temp[1];
            var playerName = temp[2];

            try
            {
                legue.Find(n => n.Name.Equals(teamName)).RemovePlayer(playerName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CalculateRating(string[] temp, List<Team> legue)
        {
            var teamName = temp[1];
            if (legue.Exists(n => n.Name.Equals(teamName)))
            {
                teamName = temp[1];

                Console.WriteLine($"{teamName} - {Math.Round(legue.Find(n => n.Name.Equals(teamName)).CalculateRating())}");
            }

            else
            {
                Console.WriteLine($"Team{teamName} does not exist.");
            }

        }
    }
}
