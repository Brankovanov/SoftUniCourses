using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_06_ReplaceATag
{
    public class replaceATag
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входния текст от конзолата.
        static void ReceiveInput()
        {
            var temp = new List<string>();
            var input = string.Empty;
            temp.Add(input);

            while (input != "end")
            {
                input = Console.ReadLine();
                temp.Add(input);
            }

            temp.Remove("end");
            ReplaceTag(temp);
        }

        //Открива търсените тагове и ги заменя.
        static void ReplaceTag(List<string> temp)
        {
            var tag = @"(<a)|(>.+<\/a>)";
            var firstTag = @"(<a)";
            var secondTag = @"(>(\w+)<\/a>)";
            var firstReplacement = "[URL";
            var secondReplacement = "]$2[/URL]";
            var outPut = string.Empty;

            foreach (var line in temp)
            {
                if (Regex.IsMatch(line, tag))
                {
                    Regex firstRegex = new Regex(firstTag);
                    outPut = firstRegex.Replace(line, firstReplacement);
                    Regex secondRegex = new Regex(secondTag);
                    outPut = Regex.Replace(outPut, secondTag, secondReplacement);
                    Print(outPut);
                }
                else
                {
                    outPut = line;
                    Print(outPut);
                }
            }
        }

        //Отпечатва изходния текст.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
