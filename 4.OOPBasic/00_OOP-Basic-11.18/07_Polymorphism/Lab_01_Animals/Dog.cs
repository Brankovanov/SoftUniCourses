using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_Animals
{
    public class Dog:Animals
    {
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF!";
        }
        public Dog(string name, string favouriteFood)
        :base(name,favouriteFood)
        {

        }
    }
}
