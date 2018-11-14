using System.Collections.Generic;

namespace Exercise_06_EqualityLogic
{
    //Class that holds comparer logic for two persons object in the hash set.
    class EqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x.Name.ToLower().Equals(y.Name.ToLower()) && x.Age == y.Age)
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(Person x)
        {
            var charArray = x.Name.ToCharArray();
            var hash = 0;

            foreach (var ch in charArray)
            {
                hash += (int)ch;
            }

            hash += x.Age;
            return hash;
        }
    }
}