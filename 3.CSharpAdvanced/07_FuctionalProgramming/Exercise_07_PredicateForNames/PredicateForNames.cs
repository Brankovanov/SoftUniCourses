using System;

namespace Exercise_07_PredicateForNames
{
    public class PredicateForNames
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            SortNames(lenght, names);
        }

        //Sorts the names according their lenght.
        public static void SortNames(int lenght, string[] names)
        {
            Predicate<int> sortNames = l => l <= lenght;

            foreach (var name in names)
            {
                if (sortNames(name.Length))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}