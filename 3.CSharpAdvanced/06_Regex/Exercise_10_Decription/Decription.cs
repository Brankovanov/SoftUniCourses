using System;
using System.Text.RegularExpressions;

namespace Exercise_10_Decription
{
    public class Decription
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives the text from the console.
        public static void ReceiveText()
        {
            var html = Console.ReadLine();
            Decript(html);
        }

        //Decrips the increpted text.
        public static void Decript(string html)
        {
            var output = string.Empty;
            var decriptionPattern = new Regex("(<p>).+?(</p>)");
            var whiteSpacePattern = new Regex("\\W+");
            var passagesToDecript = decriptionPattern.Matches(html);

            foreach (Match passage in passagesToDecript)
            {
                var decript = passage.ToString().Trim('<', 'p', '/', '>');
                var whiteSpaces = whiteSpacePattern.Matches(decript.ToString());

                foreach (Match whiteSpace in whiteSpaces)
                {
                    decript = decript.Replace(whiteSpace.ToString(), " ");

                    foreach (var ch in decript)
                    {
                        if ((int)ch > 109 & (int)ch <= 122)
                        {
                            var newChar = (char)((int)ch - 13);
                            output += newChar;
                        }
                        else if ((int)ch < 109 & (int)ch >= 92)
                        {
                            var newChar = (char)((int)ch + 13);
                            output += newChar;
                        }
                        else
                        {
                            output += ch;
                        }
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}