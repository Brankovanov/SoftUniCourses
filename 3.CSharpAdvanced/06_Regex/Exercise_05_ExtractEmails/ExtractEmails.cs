using System;
using System.Text.RegularExpressions;

namespace Exercise_05_ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receive the text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            Extract(text);
        }

        //Extract the valid emails from the text.
        public static void Extract(string text)
        {
            var emailPattern = new Regex("(^[a-zA-z0-9]{1})[\\w\\-\\.]+@([a-zA-Z]+\\-?[a-zA-Z]+)(\\.[a-zA-Z]\\-?\\w+)+");
            var temp = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in temp)
            {
                var email = emailPattern.Match(word);

                if (email.Success && (!email.ToString().StartsWith("_") || !email.ToString().StartsWith("-") || !email.ToString().StartsWith(".")))
                {
                    Console.WriteLine("-> " + email.ToString());
                }
            }
        }
    }
}