using System.Collections.Generic;

namespace Exercise_06_EqualityLogic
{
    //Holds the logic for comparing tho person objects in the sorted set.
    public class Comparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.ToLower().Equals(y.Name.ToLower()))
            {
                if (x.Age == y.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}