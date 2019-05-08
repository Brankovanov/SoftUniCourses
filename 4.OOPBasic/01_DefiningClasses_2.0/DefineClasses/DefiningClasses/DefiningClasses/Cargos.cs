namespace DefiningClasses
{
    public class Cargos
    {
        private string type;
        private int weight;

        public int Weight
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

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Cargos(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
