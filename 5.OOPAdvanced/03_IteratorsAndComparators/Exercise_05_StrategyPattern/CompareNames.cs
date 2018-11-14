using System.Collections.Generic;

namespace Exercise_05_StrategyPattern
{
    //Holding the logic for comparing to person objects by their names/.
    public class CompareNames : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length == y.Name.Length)
            {
                if (x.Name[0].ToString().ToLower() == y.Name[0].ToString().ToLower())
                {
                    return 0;
                }
                else if (char.Parse(x.Name[0].ToString().ToLower()) < char.Parse(y.Name[0].ToString().ToLower()))
                {
                    return -1;
                }
                else if (char.Parse(x.Name[0].ToString().ToLower()) > char.Parse(y.Name[0].ToString().ToLower()))
                {
                    return 1;
                }
            }
            else if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            else if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }

            return 0;
        }
    }
}