using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02_UpperCase
{
    public class UpperCase
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives collection of strings from the console.
        public static void ReceiveText()
        {
            var strings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            ToUpperCase(strings);
        }

        //Turns the strings from the collection to upper case and prints them.
        public static void ToUpperCase(List<string> strings)
        {
            foreach (var str in strings)
            {
                Console.Write(str.ToUpper() + " ");
            }
        }
    }
}