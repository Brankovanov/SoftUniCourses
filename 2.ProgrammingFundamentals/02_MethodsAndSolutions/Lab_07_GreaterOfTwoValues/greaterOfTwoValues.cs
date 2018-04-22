using System;

namespace Lab_07_GreaterOfTwoValues
{
    public class greaterOfTwoValues
    {
        public static void Main(string[] args)
        {
            var typeOfInput = Console.ReadLine();

            var firstInput = string.Empty;
            var secondInput = string.Empty;

            Input(typeOfInput, firstInput, secondInput);
        }

        static void Input(string typeOfInput, string firstInput, string secondInput)
        {
            firstInput = Console.ReadLine();
            secondInput = Console.ReadLine();

            CheckType(typeOfInput, firstInput, secondInput);
        }

        static void CheckType(string typeOfInput, string firstInput, string secondInput)
        {
            if (typeOfInput.Equals("int"))
            {
                int.TryParse(firstInput, out int firstValue);
                int.TryParse(secondInput, out int secondValue);
                GetMax(firstValue, secondValue);
            }
            else if (typeOfInput.Equals("char"))
            {
                char.TryParse(firstInput, out char firstValue);
                char.TryParse(secondInput, out char secondValue);

                GetMax(firstValue, secondValue);
            }
            else if (typeOfInput.Equals("string"))
            {
                var firstValue = firstInput;
                var secondValue = secondInput;
                GetMax(firstValue, secondValue);
            }

        }

        static void GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }

        static void GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }

        static void GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }

    }
}
