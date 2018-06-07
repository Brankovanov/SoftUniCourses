using System;
using System.Text.RegularExpressions;

namespace Exercise_02_ExtractSentencesByKeyWord
{
    public class extractSeentenceByKeyWord
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Получава текст чрез конзолата.
        static void ReceiveText()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            SortText(input, key);
        }

        //Сортира текста по дадения ключ.
        static void SortText(string input, string key)
        {
            var keyWord = $"\\b{key}\\b";
            var temp = input.Split('.', '!', '?');

            foreach(var sentence in temp)
            {
                if(Regex.IsMatch(sentence,keyWord)==true)
                {
                    PrintChosenSentences(sentence.Trim());
                }
            }       
        }

        //Принтира изреченията, които съдържат ключовата дума.
        static void PrintChosenSentences(string sentence)
        {         
                Console.WriteLine(sentence.Trim());         
        }
    }
}