using System;
using System.Text.RegularExpressions;

namespace Lab_09_ExtractQuotations
{
    public class ExtractQuotations
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives the text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            SeekQuotations(text);
        }

        //Seeks quotations in the text.
        public static void SeekQuotations(string text)
        {
            var quotationPattern = new Regex("((\")([^\"]+)(\"))|((\')([^\']+)(\'))");
            var quotations = quotationPattern.Matches(text);
            PrintQuotations(quotations);
        }

        //Prints the found quotations.
        public static void PrintQuotations(MatchCollection quotations)
        {
            foreach (Match quotation in quotations)
            {
                var quote = quotation.ToString().Remove(0, 1);
                quote = quote.Remove(quote.Length - 1, 1);
                Console.WriteLine(quote);
            }
        }
    }
}