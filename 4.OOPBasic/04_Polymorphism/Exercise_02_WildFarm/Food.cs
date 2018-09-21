namespace Exercise_02_WildFarm
{
    //Parent class that holds the food's type and quantity.
    public abstract class Food
    {
        private int quantity;
        private string type;

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

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public Food(int quantity, string type)
        {
            this.Quantity = quantity;
            this.Type = type;
        }
    }
}