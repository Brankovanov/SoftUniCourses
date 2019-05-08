namespace DefiningClasses
{
    public class EngineForSale
    {
        private string model;
        private string power;
        private string displacement;
        private string effectiveness;
        
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

        public string Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public string Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Effectiveness
        {
            get
            {
                return this.effectiveness;
            }
            set
            {
                this.effectiveness = value;
            }
        }

        public EngineForSale(string model, string power,
            string displacement, string effectiveness)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Effectiveness = effectiveness;
        }
    }
}
