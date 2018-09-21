namespace Exercise_02_WildFarm
{
    //A child class to the parent class mamal.
    public abstract class Feline : Mammal
    {
        public Feline(string animalName, string animalType, double weight, int foodEaten, string livingRegion)
            : base(animalName, animalType, weight, foodEaten, livingRegion)
        {
        }
    }
}