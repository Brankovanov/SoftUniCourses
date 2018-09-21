namespace Exercise_02_WildFarm
{
    //A child class to the parent class feline. Holds the cat's breed.
    public class Cat : Feline
    {
        private string breed;

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public Cat(string animalName, string animalType, double weight, int foodEaten, string livingRegion, string breed)
           : base(animalName, animalType, weight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return this.AnimalType + " [" + this.AnimalName + ", " + this.Breed + ", " + this.Weight + ", " + this.LivingRegion + ", " + this.FoodEaten + "]";
        }
    }
}