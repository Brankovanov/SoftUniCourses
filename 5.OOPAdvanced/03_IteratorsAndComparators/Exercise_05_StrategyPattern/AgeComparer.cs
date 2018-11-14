using System;
using System.Collections.Generic;

namespace Exercise_05_StrategyPattern
{
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age == y.Age)
            {
                return 0;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else if (x.Age > y.Age)
            {
                return 1; 
            }

            return 0;
        }
    }
}