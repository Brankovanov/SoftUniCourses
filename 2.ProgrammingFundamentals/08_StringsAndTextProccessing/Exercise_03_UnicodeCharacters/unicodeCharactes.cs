using System;

namespace Exercise_03_UnicodeCharacters
{
    public class unicodeCharactes
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема текст от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            TransformInput(input);
        }

        //Трансформира текста получен от конзолата в поредица от Unicode character literals.
        static void TransformInput(string input)
        {
            var output = string.Empty;

            foreach(var ch in input)
            {
                output += "\\u" + ((int)ch).ToString("x4");
            }

            Print(output);
        }

        //Принтира трансформирания текст на конзолата.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
