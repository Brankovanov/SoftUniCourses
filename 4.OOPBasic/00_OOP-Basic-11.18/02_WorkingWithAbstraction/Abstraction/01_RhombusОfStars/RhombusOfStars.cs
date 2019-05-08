using System;

namespace _01_RhombusОfStars
{
    public class RhombusOfStars
    {
        public static void Main()
        {
            Input();
        }

        public static void Input()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            PrintRhombus(CreateRhombus(inputNumber));
        }

        public static string CreateRhombus(int inputNumber)
        {
            var rhombus = string.Empty;

            for (var line = 0; line <= inputNumber; line++)
            {

                rhombus += new string(' ', inputNumber - line) + Createline(line, inputNumber) + Environment.NewLine; ;
            }

            for (var line = inputNumber - 1; line >= 1; line--)
            {

                rhombus += new string(' ', inputNumber - line) + Createline(line, inputNumber) + Environment.NewLine; ;
            }

            return rhombus;
        }

        public static string Createline(int line, int inputNumber)
        {
            var l = string.Empty;


            for (var symbol = 1; symbol <= line; symbol++)
            {
                l += "* ";
            }


            return l.Trim();

        }
        public static void PrintRhombus(string rhombus)
        {
            Console.WriteLine(rhombus);
        }
    }
}