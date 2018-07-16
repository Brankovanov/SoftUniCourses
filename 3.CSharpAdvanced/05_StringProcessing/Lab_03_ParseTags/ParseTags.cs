using System;

namespace Lab_03_ParseTags
{
    public class ParseTags
    {
        public static void Main(string[] args)
        {
            ReceiveString();
        }

        //Receives string from the console.
        public static void ReceiveString()
        {
            var text = Console.ReadLine();
            ProcessString(text);
        }

        //Processes the incoming string.
        public static void ProcessString(string text)
        {
            while (text.Contains("<upcase>") && text.Contains("</upcase>"))
            {
                var substring = text.Substring(text.IndexOf("<upcase>"), text.IndexOf("</upcase>") - text.IndexOf("<upcase>") + 9);
                var final = substring.Replace("<upcase>", null);
                final = final.Replace("</upcase>", null);
                final = final.ToUpper();
                text = text.Replace(substring, final);
            }

            Print(text);
        }

        //Prints the final string.
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}