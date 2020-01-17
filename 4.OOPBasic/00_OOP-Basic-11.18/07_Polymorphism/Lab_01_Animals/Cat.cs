using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_Animals
{
   public  class Cat:Animals
    {

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "Meow!";
        }
        public Cat(string name, string favouriteFood)
        : base(name, favouriteFood)
        {

        }
    }
}
