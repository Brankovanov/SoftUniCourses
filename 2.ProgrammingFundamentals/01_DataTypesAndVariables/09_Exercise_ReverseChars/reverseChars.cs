using System;
using System.Collections.Generic;

namespace _09_Exercise_ReverseChars
{
    public class reverseChars
    {
        public static void Main(string[] args)
        {
            var listChar = new List<char>();

            for (var input =3; input>=1; input--)
            {
                listChar.Add(char.Parse(Console.ReadLine()));
            }

            listChar.Reverse();

            foreach (var ch in listChar)
            {
                Console.Write(ch);
            }
        }
    }
}
