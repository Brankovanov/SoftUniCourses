using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_08_LettersChangeNumbers
{
    public class lettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входа, като текст от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ', '\t').ToList();
            var end = Console.ReadLine();

            PlayTheGame(input);
        }

        //Обработва входната информация съгласно правилата на играта.
        static void PlayTheGame(List<string> input)
        {
            var letters = File.ReadAllLines("./alphabet.txt").ToList();
            var leftLetter = string.Empty;
            var rightLetter = string.Empty;
            var number = 0.0;
            var result = 0.0;
            var finalResult = 0.0;

            foreach (var item in input)
            {
                if (!item.Equals(""))
                {
                    leftLetter = item[0].ToString();
                    rightLetter = item.Last().ToString();
                    number = double.Parse(item.Substring(1, item.Length - 2));

                    finalResult += CalculateRightLetter(rightLetter, number, letters, CalculateLeftLetter(leftLetter, number, result, letters));
                    leftLetter = string.Empty;
                    rightLetter = string.Empty;
                    number = 0.0;
                    result = 0.0;
                }
            }

            PrintResult(finalResult);
        }

        //Изчислява ефекта на буквата от лявата страна.
        static double CalculateLeftLetter(string leftLetter, double number, double result, List<string> letters)
        {
            var index = letters.FindIndex(x => x == leftLetter.ToLowerInvariant()) + 1;

            if (letters.Contains(leftLetter))
            {
                return result = number * index;
            }
            else
            {
                return result = number / index;
            }
        }

        //Изчислява ефекта на буквата от дясната страна.
        static double CalculateRightLetter(string rightLetter, double number, List<string> letters, double result)
        {
            var index = letters.FindIndex(x => x == rightLetter.ToLowerInvariant()) + 1;

            if (letters.Contains(rightLetter))
            {
                return result = result + index;
            }
            else
            {
                return result = result - index;
            }
        }

        //Отпечатва резултата от играта.
        static void PrintResult(double finalResult)
        {
            Console.WriteLine(String.Format("{0:0.00}", finalResult));
        }
    }
}