using System;
using System.Text.RegularExpressions;

namespace Exercise_05_KeyReplacer
{
    public class keyReplacer
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава ключ и текст от конзолата.
        static void ReceiveInput()
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();

            CreateKey(key, text);
        }

        //Създава ключ.
        static void CreateKey(string key, string text)
        {
            var keyPattern = @"(^[a-zA-Z]+[\<?|\|?|\\?])(.+)([\<?|\|?|\\?][a-zA-Z]+)";
            var protoKey = Regex.Match(key, keyPattern);
            var startingKey = protoKey.Groups[1].ToString().Trim('\\', '|', '<');
            var endKey = protoKey.Groups[3].ToString().Trim('\\', '|', '<');

            SortText(text, startingKey, endKey);
        }

        //Сортира през текста и вади изразите между ключовете.
        static void SortText(string text, string startingKey, string endKey)
        {
            text = text.Replace(startingKey, "|>");
            text = text.Replace(endKey, "<|");
            var parts = text.Split('|');
            var output = string.Empty;

            foreach (var txt in parts)
            {
                if (txt.Contains(">") && txt.Contains("<"))
                {
                    output += txt.TrimStart('>').TrimEnd('<');
                }
            }

            PrintOutput(output);
        }

        //Отпечатване на изхода.
        static void PrintOutput(string output)
        {
            if (output.Length > 0)
            {
                Console.Write(output);
            }
            else
            {
                Console.Write("Empty result");
            }
        }
    }
}