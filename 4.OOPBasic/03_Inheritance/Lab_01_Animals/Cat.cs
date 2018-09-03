using System;

namespace Lab_01_Animals
{
    //Creates a cat object. Derived from animal object.
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
}
