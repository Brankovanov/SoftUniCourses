using System;

namespace Lab_8_MultiplyEvenByOdds
{
    public class multiplyEvenByOdds
    {
        public static void Main(string[] args)
        {
            var input = string.Empty;

            Input(input);
        }

        static void Input(string input)
        {
            input = Math.Abs(int.Parse(Console.ReadLine())).ToString();

            Multipliers(input);
        }

        static void Multipliers(string input)
        {
            var oddNumbers = 0;
            var evenNumbers = 0;

            foreach (var digit in input)
            {
                if (int.Parse(digit.ToString()) % 2 != 0)
                {
                    oddNumbers = oddNumbers + int.Parse(digit.ToString());
                }
                else
                {
                    evenNumbers = evenNumbers + int.Parse(digit.ToString());
                }               
            }

            Output(oddNumbers, evenNumbers);
        }

        static void Output(int oddNumbers, int evenNumbers)
        {
            Console.WriteLine(oddNumbers * evenNumbers);
        }
    }
}
