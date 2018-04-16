using System;

namespace _06_Lab_TrippleLatinLetters
{
    public class trippleLatinLetters
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (var firstLetter = 97; firstLetter < 97 + input; firstLetter++)
            {
                for (var secondLetter = 97; secondLetter < 97 + input; secondLetter++)
                {
                    for (var thirdLetter = 97; thirdLetter < 97 + input; thirdLetter++)
                    {
                        Console.Write("{0}{1}{2}", (char)firstLetter, (char)secondLetter, (char)thirdLetter);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
