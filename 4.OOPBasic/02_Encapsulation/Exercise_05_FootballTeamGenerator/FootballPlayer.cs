using System;

namespace Exercise_05_FootballTeamGenerator
{
    //Creates a football player that holds the player's name, endurance, sprint, dribble, passing, shooting. Calculates the players average rating.
    public class FootballPlayer
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

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

        public double Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    this.endurance = value;
                }
                else
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100. ");
                }
            }
        }

        public double Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    this.sprint = value;
                }
                else
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100. ");
                }
            }
        }

        public double Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    this.dribble = value;
                }
                else
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
            }
        }

        public double Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    this.passing = value;
                }
                else
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
            }
        }

        public double Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    this.shooting = value;
                }
                else
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }
            }
        }

        public FootballPlayer(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public double CalculateRating()
        {
            return (endurance + sprint + dribble + passing + shooting) / 5;
        }
    }
}