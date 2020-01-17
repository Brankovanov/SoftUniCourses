using System;

namespace _04_FootballTeam
{
    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
        private double skill;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                else
                {
                    this.name = value;
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
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                }
                else
                {
                    this.endurance = value;
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
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                }
                else
                {
                    this.sprint = value;
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
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
                else
                {
                    this.dribble = value;
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
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }
                else
                {
                    this.passing = value;
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
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }
                else
                {
                    this.shooting = value;
                }
            }
        }

        public double Skill
        {
            get
            {
                return this.skill;
            }
            private set
            {
                this.skill = value;
            }
        }

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.Skill = (endurance + sprint + dribble + passing + shooting) / 5;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Endurance}  {this.Sprint} {this.Dribble} {this.Passing} {this.Shooting} {this.Shooting} {this.Skill}";
        }

    }
}


//A player has a name and stats, which are the basis for his skill level. 
//The stats a player has are endurance, sprint, dribble, passing and shooting.
//    Each stat can be an integer in the range [0..100]. The overall skill level of a player is calculated as the average of his stats. 
//    Only the name of a player and his stats should be visible to the entire outside world. Everything else should be hidden.