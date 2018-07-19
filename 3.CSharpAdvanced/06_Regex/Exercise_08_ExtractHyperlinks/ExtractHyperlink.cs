using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_08_ExtractHyperlinks
{
    public class ExtractHyperlink
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive inputs from the console.
        public static void ReceiveInput()
        {
            var htmlList = new StringBuilder();
            var commands = Console.ReadLine();

            while (commands != "END")
            {
                htmlList = htmlList.Append(" " + commands);
                commands = Console.ReadLine();
            }

            ExtractTags(htmlList);
        }

        //Extracts the href tags.
        public static void ExtractTags(StringBuilder htmlList)
        {
            var aTagPattern = new Regex("<a[\\s]+([^>]+)>");
            var hrefPattern = new Regex("(href\\s*=\\s*(\"[^ \"]+\"))|(href\\s *=\\s * ('[^']+'))|(href\\s*=\\s*(\\S+))");
            var aTags = aTagPattern.Matches(htmlList.ToString());

            foreach (var line in aTags)
            {
                var hrefTags = hrefPattern.Match(line.ToString());
                var hreff = hrefTags.ToString().Replace("href", string.Empty);
                hreff = hreff.Trim(' ', '=');
                hreff = hreff.Trim('\'', '\"');

                if (hrefTags.Success)
                {
                    Console.WriteLine(hreff);
                }
            }
        }
    }
}