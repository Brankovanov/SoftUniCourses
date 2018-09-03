using System.Collections.Generic;

namespace Exercise_06_MordorsPlan
{
    //Creates a fooditems object that holds the various food items and how they influence Gandalf's happiness.
    public class FoodItems
    {
        private readonly Dictionary<string, int> food = new Dictionary<string, int>
        {
            { "cram", 2 },
            { "lembas", 3 },
            { "apple", 1 },
            { "melon", 1 },
            { "honeycake", 5 },
            { "mushrooms", -10 }
        };

        public int Feed(string foodItem)
        {
            if (this.food.ContainsKey(foodItem.ToLower()))
            {
                return this.food[foodItem.ToLower()];
            }
            else
            {
                return -1;
            }
        }
    }
}