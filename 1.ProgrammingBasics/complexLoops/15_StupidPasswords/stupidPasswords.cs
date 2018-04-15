using System;

namespace _15_StupidPasswords
{
    public class stupidPasswords
    {
        public static void Main(string[] args)
        {
            var numberRange = int.Parse(Console.ReadLine());
            var letterRanger = int.Parse(Console.ReadLine());
            var firstLetterChar = 'a';
            var secondLetterChar = 'a';

            for (var firstDigit = 1; firstDigit < numberRange; firstDigit++)
            {
                for (var secondDigit = 1; secondDigit < numberRange; secondDigit++)
                {
                    for (var firstLetter = 1; firstLetter <= letterRanger; firstLetter++)
                    {
                        for (var secondLetter = 1; secondLetter <= letterRanger; secondLetter++)
                        {
                            if (firstDigit > secondDigit)
                            {
                                for (var lastDigit = firstDigit + 1; lastDigit <= numberRange; lastDigit++)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, firstLetterChar, secondLetterChar, lastDigit);
                                }
                            }
                            else
                            {
                                for (var lastDigit = secondDigit + 1; lastDigit <= numberRange; lastDigit++)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, firstLetterChar, secondLetterChar, lastDigit);
                                }
                            }
                            secondLetterChar++;
                        }
                        secondLetterChar = 'a';
                        firstLetterChar++;
                    }
                    firstLetterChar = 'a';
                }
            }
        }
    }
}
