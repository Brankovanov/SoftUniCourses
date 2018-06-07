using System;
using System.Text.RegularExpressions;

namespace Lab_01_MatchNames
{
    public class matchNames
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            FindNames(input);
        }

        //Намера пълни имена в масива с имена.
        static void FindNames(string input)
        {
            var match = @"\b[A-Z][a-z]+[ ]+[A-Z][a-z]+\b";
            var names = Regex.Matches(input, match);

            foreach(Match name in names)
            {
                Print(name);
            }           
        }

        //Принтира съвпаденията.
        static void Print(Match name)
        {
            Console.Write(name.Value + " ");
        }
    }
}