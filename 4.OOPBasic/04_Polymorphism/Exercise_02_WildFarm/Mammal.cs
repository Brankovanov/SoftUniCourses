namespace Exercise_02_WildFarm
{
    //A child class of the parent class animal. Holds the living region of the animal.
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion
        {
            get
            {
                return this.livingRegion;
            }
            set
            {
                this.livingRegion = value;
            }
        }

        public Mammal(string animalName, string animalType, double weight, int foodEaten, string livingRegion)
            : base(animalName, animalType, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return this.AnimalType + "[" + this.AnimalName + "," + this.Weight + "," + this.LivingRegion + "," + this.FoodEaten + "]";
        }
    }
}