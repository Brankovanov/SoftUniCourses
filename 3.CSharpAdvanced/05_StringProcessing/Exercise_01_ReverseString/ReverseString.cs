using System;
using System.Linq;

namespace Exercise_01_ReverseString
{
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            ReceiveString();
        }

        //Receives string from  the console.
        public static void ReceiveString()
        {
            var text = Console.ReadLine();
            Reverse(text);
        }

        //Reverses the the sring.
        public static void Reverse(string text)
        {
            var reverse = text.Reverse().ToArray();
            Print(reverse);
        }

        //Prints the reversedString.
        public static void Print(char[] reverse)
        {
            Console.WriteLine(string.Join(string.Empty, reverse));
        }
    }
}