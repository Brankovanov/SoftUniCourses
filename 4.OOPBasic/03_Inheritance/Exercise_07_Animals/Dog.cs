﻿namespace Exercise_07_Animals
{
    //Child class of animal. It can produce specific sound.
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender, string kind)
           : base(name, age, gender, kind)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}