using System;

namespace Exercise_02_WildFarm
{
    //Child class to the parent class feline.
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double weight, int foodEaten, string livingRegion)
            : base(animalName, animalType, weight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override void Eat(Food food)
        {
            if (food.Type == "Meat")
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
        }
    }
}