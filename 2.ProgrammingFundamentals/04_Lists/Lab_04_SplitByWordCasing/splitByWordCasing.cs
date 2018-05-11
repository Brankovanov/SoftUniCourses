using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_SplitByWordCasing
{
    public class splitByWordCasing
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            SplitString(input);
        }

        static void SplitString(string input)
        {
            var stringList = input.Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();

            SortArray(stringList);
        }

        static void SortArray(List<string> stringList)
        {
            List<string> upperList = new List<string>();
            List<string> lowerList = new List<string>();
            List<string> mixedList = new List<string>();
            string[] alphabetArray = new string[]
            { "a", "b", "c", "d", "e", "f", "g", "h",
              "i", "j", "k", "l", "m", "n", "o", "p",
              "q", "r", "s", "t", "u", "v", "w", "x",
              "y", "z" };

            var wordLength = 0;

            foreach (var word in stringList)
            {
                if (word != "")
                {
                    foreach (var s in word)
                    {
                        foreach (var letter in alphabetArray)
                        {
                            if (s.ToString().ToLower().Equals(letter))
                            {
                                wordLength++;
                            }
                        }
                    }

                    if (wordLength == word.Count())
                    {
                        if (word.Equals(word.ToUpperInvariant()))
                        {
                            upperList.Add(word);
                        }
                        else if (word.Equals(word.ToLowerInvariant()))
                        {
                            lowerList.Add(word);
                        }
                        else
                        {
                            mixedList.Add(word);
                        }

                        wordLength = 0;
                    }
                    else
                    {
                        mixedList.Add(word);
                        wordLength = 0;
                    }
                }
            }

            Print(upperList, lowerList, mixedList);
        }

        static void Print(List<string> upperList, List<string> lowerList, List<string> mixedList)
        {
            var lowerCase = "Lower-case: ";
            var mixedCase = "Mixed-case: ";
            var upperCase = "Upper-case: ";

            foreach (var lowWord in lowerList)
            {
                lowerCase += lowWord + ", ";
            }

            foreach (var mixWord in mixedList)
            {
                mixedCase += mixWord + ", ";
            }

            foreach (var upWord in upperList)
            {
                upperCase += upWord + ", ";
            }

            Console.WriteLine(lowerCase.Remove(lowerCase.Length - 2, 2));
            Console.WriteLine(mixedCase.Remove(mixedCase.Length - 2, 2));
            Console.WriteLine(upperCase.Remove(upperCase.Length - 2, 2));
        }
    }
}
