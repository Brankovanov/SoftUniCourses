using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_14_FootballLegue
{
    public class football
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var decryptKey = Console.ReadLine();
            var matches = Console.ReadLine();
            var placing = new Dictionary<string, Team>();

            while (matches != "final")
            {
                SplitAndDecryptTheInput(matches, decryptKey, placing);
                matches = Console.ReadLine();
            }

            PrintResults(placing);
        }

        //Splits the input information.
        static void SplitAndDecryptTheInput(string matches, string decryptKey, Dictionary<string, Team> placing)
        {
            var temp = matches.Split(' ').ToList();
            var tempResults = temp[2].Split(':').ToList();
            var one = temp[0];
            var two = temp[1];

            var firstTeam = new string(DecryptTeamOne(one, decryptKey));
            var secondTeam = new string(DecryptTeamTwo(two, decryptKey));
            var goalsTeamOne = int.Parse(tempResults[0]);
            var goalsTeamTwo = int.Parse(tempResults[1]);

            var pointsTeamOne = CalculatePoints(goalsTeamOne, goalsTeamTwo)[0];
            var pointsTeamTwo = CalculatePoints(goalsTeamOne, goalsTeamTwo)[1];

            CreatePlacingTable(firstTeam, secondTeam, goalsTeamOne, goalsTeamTwo, placing, pointsTeamOne, pointsTeamTwo);
        }

        //Decrypts the name of the first team.
        static char[] DecryptTeamOne(string one, string decryptKey)
        {
            one = one.Remove(0, one.IndexOf(decryptKey) + decryptKey.Length);
            one = one.Remove(one.LastIndexOf(decryptKey));
            var first = one.ToUpper().Reverse().ToArray();
            return first;
        }

        //Decrypts the name of the second team.
        static char[] DecryptTeamTwo(string two, string decryptKey)
        {
            two = two.Remove(0, two.IndexOf(decryptKey) + decryptKey.Length);
            two = two.Remove(two.LastIndexOf(decryptKey));
            var second = two.ToUpper().Reverse().ToArray();
            return second;
        }

        //Calculates the points that the teams receive after every match.
        static int[] CalculatePoints(int goalsTeamOne, int goalsTeamTwo)
        {
            int[] points = new int[2];
            var one = 0;
            var two = 0;

            if (goalsTeamOne == goalsTeamTwo)
            {
                one = 1;
                two = 1;
            }
            else if (goalsTeamOne > goalsTeamTwo)
            {
                one = 3;
                two = 0;
            }
            else if (goalsTeamOne < goalsTeamTwo)
            {
                one = 0;
                two = 3;
            }

            points[0] = one;
            points[1] = two;

            return points;
        }

        //Creates a dictionary of objects that holds all the team their goals and points.
        static void CreatePlacingTable(string firstTeam, string secondTeam,
            int goalsTeamOne, int goalsTeamTwo, Dictionary<string, Team> placing,
            int pointsTeamOne, int pointsTeamTwo)
        {
            if (!placing.ContainsKey(firstTeam))
            {
                Team newTeam = new Team();
                newTeam.Goals = goalsTeamOne;
                newTeam.Points = pointsTeamOne;

                placing.Add(firstTeam, newTeam);
            }
            else
            {
                placing[firstTeam].Goals += goalsTeamOne;
                placing[firstTeam].Points += pointsTeamOne;
            }

            if (!placing.ContainsKey(secondTeam))
            {
                Team newTeam = new Team();
                newTeam.Goals = goalsTeamTwo;
                newTeam.Points = pointsTeamTwo;

                placing.Add(secondTeam, newTeam);
            }
            else
            {
                placing[secondTeam].Goals += goalsTeamTwo;
                placing[secondTeam].Points += pointsTeamTwo;
            }
        }

        //Prints the final result from all the matches.
        static void PrintResults(Dictionary<string, Team> placing)
        {
            var place = 1;
            Console.WriteLine("League standings:");

            foreach (var team in placing.OrderByDescending(t => t.Value.Points).ThenBy(tn => tn.Key))
            {
                Console.WriteLine(place + ". " + team.Key + " " + team.Value.Points);
                place++;
            }

            place = 1;
            Console.WriteLine("Top 3 scored goals:");

            foreach (var competitor in placing.OrderByDescending(g => g.Value.Goals).ThenBy(gn => gn.Key))
            {
                if (place <= 3)
                {
                    Console.WriteLine("- " + competitor.Key + " -> " + competitor.Value.Goals);
                    place++;
                }
                else
                {
                    break;
                }
            }
        }
    }

    //Class Team creates objects newTeam.
    public class Team
    {
        private int goals;
        private int points;

        public int Goals
        {
            get
            {
                return this.goals;
            }
            set
            {
                this.goals = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public Team()
        {

            this.goals = Goals;
            this.points = Points;
        }
    }
}