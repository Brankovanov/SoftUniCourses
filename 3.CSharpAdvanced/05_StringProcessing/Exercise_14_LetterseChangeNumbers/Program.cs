using System;

namespace Exercise_14_LetterseChangeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives number letter sequences from the console.
        public static void ReceiveInput()
        {
            var sequences = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            CalculateNumbers(sequences);
        }

        //Calculates the sum of the numbers from the sequence.
        public static void CalculateNumbers(string[] sequences)
        {
            var firstLetter = string.Empty;
            var lastLetter = string.Empty;
            var number = 0.0;
            var result = 0.0;

            foreach (var sequence in sequences)
            {
                firstLetter = sequence[0].ToString();
                lastLetter = sequence[sequence.Length - 1].ToString();
                number = double.Parse(sequence.Substring(1, sequence.Length - 2));

                if (firstLetter.Equals(firstLetter.ToUpper()))
                {
                    number = number / ((int)char.Parse(firstLetter) - 64);
                }
                else
                {
                    number = number * ((int)char.Parse(firstLetter) - 96);
                }

                if (lastLetter.Equals(lastLetter.ToUpper()))
                {
                    number = number - ((int)char.Parse(lastLetter) - 64);
                }
                else
                {
                    number = number + ((int)char.Parse(lastLetter) - 96);
                }

                result += number;
            }

            PrintResult(result);
        }

        //Prints the final result on the console.
        public static void PrintResult(double result)
        {
            Console.WriteLine(string.Format("{0:0.00}", result));
        }
    }
}