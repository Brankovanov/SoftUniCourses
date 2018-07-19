using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_04_ReplaceTags
{
    public class ReplaceTags
    {
        public static void Main(string[] args)
        {
            ReceiveHTML();
        }

        //Receives names from the console.
        public static void ReceiveHTML()
        {
            var html = Console.ReadLine();
            var htmlList = new List<string>();

            while (html != "end")
            {
                ReplaceTag(html, htmlList);
                html = Console.ReadLine();
            }

            Print(htmlList);
        }

        //Finds if the given name is valid.
        public static void ReplaceTag(string html, List<string> htmlList)
        {
            var tag = new Regex($"(<a).+(</a>)");
            var tags = tag.Match(html);

            if (tags.Success)
            {
                var reformed = tags.ToString().Replace("<a", "[URL");
                reformed = reformed.Replace("</a>", "[/URL]");

                if (reformed.Contains(">"))
                {
                    reformed = reformed.Replace(">", "]");
                }

                html = html.Replace(tags.ToString(), reformed);
            }

            htmlList.Add(html);
        }

        //Prints the reformed html.
        public static void Print(List<string> htmlList)
        {
            foreach (var line in htmlList)
            {
                Console.WriteLine(line);
            }
        }
    }
}