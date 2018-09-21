namespace Lab_02_Animals
{
    //Parent class that holds the animals' name, favourite food and general behaviour.
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string FavouriteFood
        {
            get
            {
                return this.favouriteFood;
            }
            set
            {
                this.favouriteFood = value;
            }
        }

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}