using System;
using System.Text.RegularExpressions;

namespace Lab_03_MatchHexagonicalNumbers
{
    public class matchHexagonicalNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        public static void ReceiveInput()
        {
            var input = Console.ReadLine();
            SortHexagonical(input);
        }

        //Отсява числата в шестнадесетична бройна система.
        static void SortHexagonical(string input)
        {
            var hex = @"\b(?:0x)?[0-9A-F]+\b";
            var hexNumbers = Regex.Matches(input, hex);

            PrintHexagonicalNumbers(hexNumbers);
        }

        //Принтира шестнадесетичните числа.
        static void PrintHexagonicalNumbers(MatchCollection hexNumbers)
        {
            foreach (Match number in hexNumbers)
            {
                Console.Write(number.Value + " ");
            }
        }
    }
}