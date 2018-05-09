using System;

namespace Exercise_09_IndexOfLetter
{
    public class indexOfLetter
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            FindIndex(input);
        }

        static void FindIndex(string input)
        {
            string[] alphabetArray = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            foreach (var symbol in input)
            {
                for (var index = 0; index <= alphabetArray.Length - 1; index++)
                {
                    if (symbol.ToString().Equals(alphabetArray[index]))
                    {
                        Console.WriteLine(symbol.ToString() + " -> " + index.ToString());
                    }
                }
            }
        }
    }
}
