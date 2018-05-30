using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_TeamworkProjects
{
    public class teamWorkProjects
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема списък с участници от конзолата.
        static void ReceiveInput()
        {
            List<string> listOfParticipants = new List<string>();
            var countOfTeams = int.Parse(Console.ReadLine());
            var participant = Console.ReadLine();
            listOfParticipants.Add(participant);

            while (participant != "end of assignment")
            {
                participant = Console.ReadLine();
                listOfParticipants.Add(participant);
            }

            listOfParticipants.Remove("end of assignment");
            SortParticipants(listOfParticipants);
        }

        //Разпределя участниците според това,
        //дали създават нови отбори или се включват в съществуващи такива.
        static void SortParticipants(List<string> listOfParticipants)
        {
            List<Teams> listOfTeams = new List<Teams>();
            List<string> temp = new List<string>();
            var participantName = string.Empty;
            var teamName = string.Empty;

            foreach (var participant in listOfParticipants)
            {
                temp = participant.Split('-').ToList();
                participantName = temp[0];
                teamName = temp[1];

                if (teamName.Contains('>'))
                {
                    teamName = teamName.Remove(0, 1);
                    JoinTeam(listOfTeams, participantName, teamName);
                }
                else
                {
                    CreateTeam(listOfTeams, participantName, teamName);
                }

                participantName = string.Empty;
                teamName = string.Empty;
            }

            Print(listOfTeams);
        }

        //Създава нови обекти Team.
        static void CreateTeam(List<Teams> listOfTeams, string participantName, string teamName)
        {
            if (!listOfTeams.Any(x => x.TeamName.Equals(teamName)) && !listOfTeams.Any(x => x.TeamCreater.Equals(participantName)))
            {
                Teams newTeam = new Teams();
                newTeam.TeamName = teamName;
                newTeam.TeamCreater = participantName;
                newTeam.TeamMembers = new List<string>();
                newTeam.TeamMembers.Add(participantName);
                listOfTeams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {participantName}!");
            }
            else if (listOfTeams.Any(x => x.TeamName.Equals(teamName)))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (!listOfTeams.Any(x => x.TeamName.Equals(teamName)) && listOfTeams.Any(x => x.TeamCreater.Equals(participantName)))
            {
                Console.WriteLine($"{participantName} cannot create another team!");
            }
        }

        //Присъединява нови членове към съществуващите отбори.
        static void JoinTeam(List<Teams> listOfTeams, string participantName, string teamName)
        {
            if (!listOfTeams.Any(x => x.TeamName.Equals(teamName)))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (listOfTeams.Any(x => x.TeamMembers.Contains(participantName)))
            {
                Console.WriteLine($"Member {participantName} cannot join team {teamName}!");
            }
            else if (listOfTeams.Any(x => x.TeamName.Equals(teamName)) && !listOfTeams.Any(x => x.TeamMembers.Contains(participantName)))
            {
                foreach (var team in listOfTeams)
                {
                    if (team.TeamName == teamName)
                    {
                        team.TeamMembers.Add(participantName);
                        team.Position++;
                        break;
                    }
                }
            }
        }

        //Принтира създадените отбори.
        static void Print(List<Teams> listOfTeams)
        {
            listOfTeams = listOfTeams.OrderByDescending(y => y.Position).ThenBy(z => z.TeamName).ToList();

            foreach (var team in listOfTeams)
            {
                if (team.Position != 0)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine("- " + team.TeamCreater);

                    for (var index = 1; index <= team.Position; index++)
                    {
                        Console.WriteLine("-- " + team.TeamMembers[index]);
                    }
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in listOfTeams)
            {
                if (team.TeamMembers.Count == 1)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }

        //Клас Team, който създава обекти newTeam.
        public class Teams
        {
            private string teamName;
            private string teamCreater;
            private List<string> teamMembers;
            private int position;

            public string TeamName
            {
                get
                {
                    return this.teamName;
                }
                set
                {
                    this.teamName = value;
                }
            }

            public string TeamCreater
            {
                get
                {
                    return this.teamCreater;
                }
                set
                {
                    this.teamCreater = value;
                }
            }

            public int Position
            {
                get
                {
                    return this.position;
                }
                set
                {
                    this.position = value;
                }
            }

            public List<string> TeamMembers
            {
                get
                {
                    return this.teamMembers;
                }
                set
                {
                    this.teamMembers = value;
                }
            }

            public Teams()
            {
                this.teamCreater = TeamCreater;
                this.teamMembers = TeamMembers;
                this.teamName = TeamName;
                this.position = Position;
            }
        }
    }
}