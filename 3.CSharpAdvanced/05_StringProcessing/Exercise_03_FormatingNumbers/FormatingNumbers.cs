using System;

namespace Exercise_03_FormatingNumbers
{
    public class FormatingNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives the numbers from the console.
        public static void ReceiveNumbers()
        {
            var input = Console.ReadLine().Split(' ');
            var firstNumber = int.Parse(input[0]);
            var secondNumber = double.Parse(input[1]);
            var thirdNumber = double.Parse(input[2]);
            FormatNumber(firstNumber, secondNumber, thirdNumber);
        }

        //Formats the numbers according the requirements.
        public static void FormatNumber(int firstNumber, double secondNumber, double thirdNumber)
        {
            var firstColumn = firstNumber.ToString("X");
            firstColumn = firstColumn.PadRight(firstColumn.Length + (10 - firstColumn.Length), ' ');
            var secondColumn = string.Empty;

            if (Convert.ToString(firstNumber, 2).Length <= 10)
            {
                secondColumn = Convert.ToString(firstNumber, 2).PadLeft(Convert.ToString(firstNumber, 2).Length + (10 - Convert.ToString(firstNumber, 2).Length), '0');
            }
            else
            {
                secondColumn = Convert.ToString(firstNumber, 2).Substring(0, 10);
            }

            var thirdColumn = string.Format("{0:0.00}", secondNumber).PadLeft(string.Format("{0:0.00}", secondNumber).Length + (10 - string.Format("{0:0.00}", secondNumber).Length), ' ');
            var fourthColumn = string.Format("{0:0.000}", thirdNumber).PadRight(string.Format("{0:0.000}", thirdNumber).Length + (10 - string.Format("{0:0.000}", thirdNumber).Length), ' ');
            Print(firstColumn, secondColumn, thirdColumn, fourthColumn);
        }

        //Prints the result on the console.
        public static void Print(string firstColumn, string secondColumn, string thirdColumn, string fourthColumn)
        {
            Console.WriteLine("|" + firstColumn + "|" + secondColumn + "|" + thirdColumn + "|" + fourthColumn + "|");
        }
    }
}