namespace Exercise_02_WildFarm
{
    //Parent class animal that holds the animals general characteristics - name, type, weight and food consumed.
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double weight;
        private int foodEaten;

        public string AnimalName
        {
            get
            {
                return this.animalName;
            }
            set
            {
                this.animalName = value;
            }
        }

        public string AnimalType
        {
            get
            {
                return this.animalType;
            }
            set
            {
                this.animalType = value;
            }
        }

        public double Weight
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

        public int FoodEaten
        {
            get
            {
                return this.foodEaten;
            }
            set
            {
                this.foodEaten = value;
            }
        }

        public Animal(string animalName, string animalType, double weight, int foodEaten)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public virtual string MakeSound()
        {
            return string.Empty;
        }

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public virtual string ToString()
        {
            return string.Empty;
        }
    }
}