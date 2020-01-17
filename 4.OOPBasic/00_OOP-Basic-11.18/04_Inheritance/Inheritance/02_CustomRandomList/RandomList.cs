using System;
using System.Collections.Generic;

namespace _02_CustomRandomList
{
    public class RandomList:List<string>
    { 
        public Random randomGenerator { get; set; }

        public RandomList()
        {
            this.randomGenerator = new Random();
        }

        public string GetRandomElement()
        {
            var index = randomGenerator.Next(0, Count - 1);
            var result = this[index];
            this.RemoveAt(index);

            return result;
        }

    }
}
