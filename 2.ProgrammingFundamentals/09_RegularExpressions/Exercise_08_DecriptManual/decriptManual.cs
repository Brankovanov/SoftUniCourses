using System;
using System.Text.RegularExpressions;

namespace Exercise_08_DecriptManual
{
    public class decriptManual
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход под формата на html от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            ExtractText(input);
        }

        //Извлича текста от входния html. 
        static void ExtractText(string input)
        {
            var pattern = @"(<p>(.*?)<\/p>)";
            var whiteSpaceSymbolPattern = @"[^a-z0-9]+";
            var text = Regex.Matches(input, pattern);

            foreach (Match fragment in text)
            {
                var decoded = fragment.Groups[2].ToString();
                decoded = Regex.Replace(decoded, whiteSpaceSymbolPattern, " ");

                Decode(decoded);
            }
        }

        //Декриптира и отпечатва криптирания текст.
        static void Decode(string decoded)
        {
            var final = string.Empty;
            foreach (var ch in decoded)
            {
                if ((int)ch > 109 & (int)ch <= 122)
                {
                    var newChar = (char)((int)ch - 13);
                    final += newChar;
                }
                else if ((int)ch < 109 & (int)ch >= 92)
                {
                    var newChar = (char)((int)ch + 13);
                    final += newChar;
                }
                else
                {
                    final += ch;
                }

                final = final.Replace("  ", " ");
            }

            Console.Write(final);
        }
    }
}