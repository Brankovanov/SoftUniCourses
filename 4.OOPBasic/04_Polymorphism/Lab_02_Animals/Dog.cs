using System;

namespace Lab_02_Animals
{
    //Derived class from animal. Holds the a modified behaviour and takes name and favourite food from the parent class.
    public class Dog : Animal
    {
        public Dog(string name, string food)
           : base(name, food)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}