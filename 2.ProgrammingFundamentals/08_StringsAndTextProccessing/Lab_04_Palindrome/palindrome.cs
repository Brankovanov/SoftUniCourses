using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_Palindrome
{
    public class palindrome
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава текста, който да сортира от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            SortText(input);
        }

        //Сортира дадения текст.
        static void SortText(string input)
        {
            var tempList = input.Split(',', '.', ' ', '!', '?');
            List<string> output = new List<string>();

            foreach (var word in tempList)
            {
                if (word != "")
                {
                    var comparator = new string(word.Reverse().ToArray());

                    if (comparator.Equals(word.Trim()) && !output.Contains(word))
                    {
                        output.Add(word);
                    }
                }
            }

            Print(output);
        }

        //Отпечатва намерените палиндроми.
        static void Print(List<string> output)
        {
            output = output.OrderBy(x => x).ToList();

            for (var index = 0; index <= output.Count - 1; index++)
            {
                if (index != output.Count - 1)
                {
                    Console.Write(output[index] + ", ");
                }
                else
                {
                    Console.Write(output[index]);
                }
            }
        }
    }
}
