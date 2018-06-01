using System;

namespace Lab_02_NumberOfOccurrences
{
    public class numberOfOccurrences
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входни данни от конзолата.
        static void ReceiveInput()
        {
            var text = Console.ReadLine().ToLowerInvariant();
            var subString = Console.ReadLine().ToLowerInvariant();
            Occurences(text, subString);
        }

        //Открива и брои търсения substring.
        static void Occurences(string text, string subString)
        {
            var counter = 0;
            text = text.ToLowerInvariant();
            var temp = string.Empty;

            while (text.Contains(subString))
            {
                temp = text.Substring(0, subString.Length);
                
                if(temp.Equals(subString))
                {
                    counter++;
                    text = text.Remove(0, 1);
                }
                else
                {
                    text = text.Remove(0, 1);
                }
            }

            Print(counter);
        }

        //Отпечатва отговора на конзолата.
        static void Print(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}
