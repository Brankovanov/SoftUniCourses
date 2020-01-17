using System;
using System.Collections.Generic;

namespace _04_FootballTeam
{
    public class Team
    {
        private string name;
        private double rating;
        private List<Player> players;

        public List<Player> Players
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
                if (value != " " && value != string.Empty && value != null)
                {
                    this.name = value;
                }
                else
                {

                    throw new ArgumentException("A name should not be empty.");
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

        public Team(string name)
        {
            this.Name = name;
            this.Rating = 0.0;
            this.Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {

            this.Players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.Players.Exists(p => p.Name == playerName))
            {
                this.Players.RemoveAll(n => n.Name == playerName);
            }
            else
            {

                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");

            }
        }

    

        public double CalculateRating()
        {

            if (this.Players.Count > 0)
            {
                foreach (var pl in this.Players)
                {
                    this.Rating += pl.Skill;
                }

                this.Rating = this.Rating / this.Players.Count;
            }
            else
            {
                this.rating = 0;
            }

            return this.Rating;
        }

    }
}
