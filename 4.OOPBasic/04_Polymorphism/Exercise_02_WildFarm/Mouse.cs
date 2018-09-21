using System;

namespace Exercise_02_WildFarm
{
    //A child class to the parent's class mamal.
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double weight, int foodEaten, string livingRegion)
           : base(animalName, animalType, weight, foodEaten, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
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