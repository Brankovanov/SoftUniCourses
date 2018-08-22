using System;
using System.Collections.Generic;

namespace Exercise_05_FootballTeamGenerator
{
    public class FootballTeamGenerator
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receuves input information from the console.
        public static void ReceiveInput()
        {
            var listOfTeams = new Dictionary<string, FootBallTeam>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var temp = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = temp[0];

                switch (command)
                {
                    case "Team":

                        var teamName = temp[1];
                        CreateTeam(listOfTeams, teamName);
                        break;

                    case "Add":

                        teamName = temp[1];
                        var playerName = temp[2];
                        var endure = double.Parse(temp[3]);
                        var run = double.Parse(temp[4]);
                        var drib = double.Parse(temp[5]);
                        var pass = double.Parse(temp[6]);
                        var shoot = double.Parse(temp[7]);

                        if (listOfTeams.ContainsKey(teamName))
                        {
                            try
                            {
                                var newPlayer = new FootballPlayer(playerName, endure, run, drib, pass, shoot);
                                listOfTeams[teamName].Players.Add(newPlayer);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        break;

                    case "Remove":

                        teamName = temp[1];
                        playerName = temp[2];

                        if (listOfTeams.ContainsKey(teamName) && listOfTeams[teamName].Players.Exists(p => p.Name == playerName))
                        {
                            listOfTeams[teamName].Players.Remove(listOfTeams[teamName].Players.Find(p => p.Name == playerName));
                        }
                        else
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                        }
                        break;

                    case "Rating":

                        teamName = temp[1];

                        if (listOfTeams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"{teamName} - {Math.Round(listOfTeams[teamName].CalculateRating())}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        break;

                }

                input = Console.ReadLine();
            }
        }

        //Creates new team.
        public static void CreateTeam(Dictionary<string, FootBallTeam> listOfTeams, string teamName)
        {
            try
            {
                var newTeam = new FootBallTeam(teamName);
                listOfTeams.Add(teamName, newTeam);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}