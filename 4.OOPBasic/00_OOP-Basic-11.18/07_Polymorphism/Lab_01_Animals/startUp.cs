using System;

namespace Lab_01_Animals
{
   public  class startUp
    {
        static void Main()
        {
            Animals cat = new Cat("Pesho", "Whiskas");
            Animals dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}


