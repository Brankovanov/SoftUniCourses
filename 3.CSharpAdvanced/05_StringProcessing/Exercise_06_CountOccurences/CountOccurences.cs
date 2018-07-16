using System;

namespace Exercise_06_CountOccurences
{
    public class CountOccurences
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var text = Console.ReadLine();
            var substring = Console.ReadLine();
            Count(text, substring);
        }

        //Counts the number of occurences of the substring.
        public static void Count(string text, string substring)
        {
            var count = 0;

            while (text.Contains(substring))
            {
                var temp = text.Substring(0, substring.Length);

                if (temp.ToLower().Equals(substring))
                {
                    count++;
                    text = text.Remove(0, 1);
                }
                else
                {
                    text = text.Remove(0, 1);
                }
            }

            Print(count);
        }

        //Prints the count of occurences in the text.
        public static void Print(int count)
        {
            Console.WriteLine(count);
        }
    }
}