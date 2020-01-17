using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value != "White" &&  value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                {
                    this.flourType = value;
                }
            }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                {
                    this.bakingTechnique = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if(value<1 && value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                else
                {
                    this.weight = value;
                }
               
            }
        }

        public Dough(string flour, string technique, double weight)
        {
            this.FlourType = flour;
            this.BakingTechnique = technique;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            var flourModifier = 0.0;
            var techniqueModifier = 0.0;

            switch(this.FlourType)
            {
                case "White":
                    flourModifier = 1.5;
                    break;
                case "Wholegrain":
                    flourModifier = 1;
                    break;
            }

            switch(this.BakingTechnique)
            {
                case "Crispy":
                    techniqueModifier = 0.9;
                    break;
                case "Chewy":
                    techniqueModifier = 1.1;
                    break;
                case "Homemade":
                    techniqueModifier = 1;
                    break;
            }

            return (2 * this.Weight) * flourModifier * techniqueModifier;

        }
    }
}