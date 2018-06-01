using System;
using System.Linq;

namespace Lab_01_ReverseString
{
    public class reverseString
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получаваме вход от конзолата.
        static void ReceiveInput()
        {
            var text = Console.ReadLine();

            ReverseText(text);
        }

        //Обръща текста и го съхранява в символен масив.
        static void ReverseText(string text)
        {
            var output = text.Reverse().ToArray();

            Print(output);
        }

        //Отпечатва символния масив.
        static void Print(char[] output)
        {        
                Console.Write(new string(output));
        }
    }
}
