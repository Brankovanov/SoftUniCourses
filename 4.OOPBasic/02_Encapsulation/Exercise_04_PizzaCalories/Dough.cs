using System;

namespace Exercise_04_PizzaCalories
{
    //Creates a dough object that holds the dought's flour, baking technique and quantity.
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private decimal weight;

        private decimal Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value > 0 && value <= 200)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
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
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string Flour
        {
            get
            {
                return this.flour;
            }
            private set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    this.flour = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public Dough(string flour, string bakingTechnique, decimal weight)
        {
            this.Flour = flour;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public decimal CalculateDoughtCalories()
        {
            var flourMod = 0.0M;
            var bakingMod = 0.0M;

            if (flour.ToLower() == "white")
            {
                flourMod = 1.5M;
            }
            else if (flour.ToLower() == "wholegrain")
            {
                flourMod = 1M;
            }

            if (bakingTechnique.ToLower() == "crispy")
            {
                bakingMod = 0.9M;
            }
            else if (bakingTechnique.ToLower() == "chewy")
            {
                bakingMod = 1.1M;
            }
            else if (bakingTechnique.ToLower() == "homemade")
            {
                bakingMod = 1M;
            }

            return (weight * 2) * flourMod * bakingMod;
        }
    }
}