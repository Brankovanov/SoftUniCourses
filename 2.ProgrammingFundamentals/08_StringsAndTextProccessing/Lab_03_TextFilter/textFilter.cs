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
        }

        //Премахва забранените думи от текста.
        static void CensorText(string text, string bannedWords)
        {
            var bannedList = bannedWords.Replace(", ", " ").Split(' ');
        }
    }
}
