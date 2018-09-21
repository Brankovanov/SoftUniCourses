using System;

namespace Exercise_02_WildFarm
{
    //A child class to the parent class mamal.
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double weight, int foodEaten, string livingRegion)
           : base(animalName, animalType, weight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Zs";
        }

        public override void Eat(Food food)
        {
            if (food.Type == "Vegetable")
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