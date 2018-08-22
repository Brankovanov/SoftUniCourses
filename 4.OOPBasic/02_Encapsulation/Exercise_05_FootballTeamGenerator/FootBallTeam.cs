using System;
using System.Collections.Generic;

namespace Exercise_05_FootballTeamGenerator
{
    //Creates a football team that holds the team's list of players, team's name and rating. It also holds methods for adding and removing players.
    public class FootBallTeam
    {
        private List<FootballPlayer> players;
        private string name;
        private double rating;

        public List<FootballPlayer> Players
        {
            get
            {
                return this.players;
            }
            private set
            {
                this.players = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("A name should not be empty. ");
                }
            }
        }

        public double Rating
        {
            get
            {
                return this.rating;
            }
            private set
            {
                this.rating = value;
            }
        }

        public FootBallTeam(string name)
        {
            this.Name = name;
            this.Players = new List<FootballPlayer>();
        }

        public void Add(FootballPlayer newPlayer)
        {
            this.Players.Add(newPlayer);
        }

        public void Remove(string name)
        {
            if (Players.Exists(p => p.Name == name))
            {
                Players.Remove(Players.Find(p => p.Name == name));
            }
            else
            {
                throw new ArgumentException($"Player {name} is not in {this.name} team.");
            }
        }

        public double CalculateRating()
        {
            foreach (var p in players)
            {
                Rating += p.CalculateRating();
            }

            if (Rating == 0 || players.Count == 0)
            {
                Rating = 0;
            }
            else
            {
                Rating = Rating / players.Count;
            }

            return Rating;
        }
    }
}