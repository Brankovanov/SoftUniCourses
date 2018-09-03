using System;

namespace Exercise_06_MordorsPlan
{
    public class MordorsPlan
    {
        public static void Main()
        {
            var newGandalf = new Gandalf();
            var newItems = new FoodItems();
            ReceiveFood(newGandalf, newItems);
        }

        //Receives what Gandalf eats from the console.
        public static void ReceiveFood(Gandalf newGandalf, FoodItems newItems)
        {
            var foods = Console.ReadLine().Split(' ');
            Calculate(foods, newGandalf, newItems);
        }

        //Calculates the results from the Gandalf's feeding.
        public static void Calculate(string[] foods, Gandalf newGandalf, FoodItems newItems)
        {
            foreach (var item in foods)
            {
                newGandalf.Eat(item, newItems);
            }

            PrintResult(newGandalf);
        }

        //Prints the final mood of Gandalf
        public static void PrintResult(Gandalf newGandalf)
        {
            Console.WriteLine(newGandalf.Happiness);
            Console.WriteLine(newGandalf.Mood());
        }
    }
}