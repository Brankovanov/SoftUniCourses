using System;
using System.Linq;

namespace Exercise_05_MagicExchangeableWords
{
    public class magicExchangeableWords
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава текстовете, които ще се сравняват от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ');

            CheckCompatibility(input);
        }

        //Проверява дали двата стринга са заменими.
        static void CheckCompatibility(string[] input)
        {           
            var checker = false;
            var counterOne = input[1].Distinct();
            var counterTwo = input[0].Distinct();

            if(counterOne.Count() == counterTwo.Count())
            {
                checker = true;
            }

            Print(checker);
        }

        //Oтпечатва отговора на конзолата.
        static void Print(bool checker)
        {
            Console.WriteLine(checker.ToString().ToLower());
        }
    }
}