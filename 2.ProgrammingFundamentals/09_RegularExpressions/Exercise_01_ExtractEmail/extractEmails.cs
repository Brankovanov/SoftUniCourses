using System;
using System.Text.RegularExpressions;

namespace Exercise_01_ExtractEmail
{
    public class extractEmails
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            SortEmail(input);
        }

        //Открива валидни емайли в текста.
        static void SortEmail(string input)
        {
            var temp = input.Split(' ');
            var emails = @"(([a-zA-Z0-9]+[\.\-_]?\w+)@{1}([a-zA-Z]+\-?[a-zA-Z]+)(\.[a-zA-Z]\-?\w+)+)";

            foreach (var inp in temp)
            {
                if (inp.StartsWith("-") || inp.StartsWith(".") || inp.StartsWith("_"))
                {
                    input = input.Replace(inp, " ");
                }
            }

            var emailsArray = Regex.Matches(input, emails);
            PrintEmails(emailsArray);
        }

        //Отпечатва валидните мейли.
        static void PrintEmails(MatchCollection emailsArray)
        {
            foreach (Match email in emailsArray)
            {

                Console.WriteLine(email.Value);
            }
        }
    }
}