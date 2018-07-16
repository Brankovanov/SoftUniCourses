using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_Palindromes
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives input text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            FindPalindromes(text);
        }

        //Finds it there are palindromes in the text.
        public static void FindPalindromes(string[] text)
        {
            var palindromeStack = new SortedSet<string>();

            foreach (var word in text)
            {
                if (word.Equals(string.Join(string.Empty, word.Reverse())))
                {
                    palindromeStack.Add(word);
                }
            }

            PrintPalindromes(palindromeStack);
        }

        //Prints the palindromes found.
        public static void PrintPalindromes(SortedSet<string> palindromeStack)
        {
            Console.Write(string.Join(", ", palindromeStack));
        }
    }
}