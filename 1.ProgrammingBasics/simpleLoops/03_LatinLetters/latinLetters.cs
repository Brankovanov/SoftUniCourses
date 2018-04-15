using System;

namespace _03_LatinLetters
{
    public class latinLetters
    {
        public static void Main(string[] args)
        {
            for (var n = 97; n <= 122; n++)
            {
                var letter = Convert.ToChar(n);
                Console.WriteLine("{0}",letter);
            }
        }
    }
}
