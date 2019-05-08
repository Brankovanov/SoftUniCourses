using System;

namespace DefiningClasses
{
    public class CarForSale
    {
        private string model;
        private EngineForSale engine;
        private string weight;
        private string color;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public EngineForSale Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public string Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public CarForSale(string model, EngineForSale engine, string weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string CarSpecifics()
        {
            var specifications = this.Model+":" + Environment.NewLine
                + "  " + this.Engine.Model+":" + Environment.NewLine
                + "    " + "Power: " + this.Engine.Power + Environment.NewLine
                + "    " + "Displacement: " + this.Engine.Displacement + Environment.NewLine
                + "    " + "Efficiency: " + this.Engine.Effectiveness + Environment.NewLine
                + "  " + "Weight: " + this.Weight + Environment.NewLine
                + "  " + "Color: " + this.Color;

            return specifications;
        }
    }
}