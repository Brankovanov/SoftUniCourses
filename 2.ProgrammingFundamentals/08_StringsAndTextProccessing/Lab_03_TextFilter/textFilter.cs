using System;

namespace Lab_03_TextFilter
{
    public class textFilter
    {
        public static void Main(string[] args)
        {
            ReceiveIntput();
        }

        //Получава входни данни от конзолата
        static void ReceiveIntput()
        {
            var bannedWords = Console.ReadLine();
            var text = Console.ReadLine();

            CensorText(text, bannedWords);
        }

        //Премахва забранените думи от текста.
        static void CensorText(string text, string bannedWords)
        {
            var bannedList = bannedWords.Replace(", ", " ").Split(' ');
            var replacement = string.Empty;

            foreach (var word in bannedList)
            {
                for (var index = 1; index <= word.Length; index++)
                {
                    replacement += "*";
                }

                while (text.Contains(word))
                {
                    text = text.Replace(word, replacement);
                }

                replacement = string.Empty;
            }

            Print(text);
        }

        //Принтира редактирания текст.
        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}