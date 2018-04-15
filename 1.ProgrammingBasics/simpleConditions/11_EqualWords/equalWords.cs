using System;

namespace _11_EqualWords
{
    public class equalWords
    {
        public static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();

            if (firstWord.ToLower().Equals(secondWord.ToLower()))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
