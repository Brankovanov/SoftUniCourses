using System;
using System.Text.RegularExpressions;

namespace Lab_06_ExtractTags
{
    public class ExtractTags
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text from the console.
        public static void ReceiveText()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                ExtractTag(line);
                line = Console.ReadLine();
            }
        }

        //Extracts tags from the console.
        public static void ExtractTag(string line)
        {
            var pattern = new Regex(@"([<]|[</])+([^>]+)(>)");
            var tags = pattern.Matches(line);
            PrintTags(tags);
        }

        //Prints the tags found in every line.
        public static void PrintTags(MatchCollection tags)
        {
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}