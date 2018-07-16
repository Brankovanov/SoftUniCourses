using System;
using System.Linq;

namespace Exercise_16_ExtractHiperlink
{
    public class ExtractHyperLink
    {
        public static void Main(string[] args)
        {
            ReceiveHtml();
        }

        //Receives HTML code from the console.
        public static void ReceiveHtml()
        {
            var finalCode = string.Empty;
            var code = Console.ReadLine();

            while (code != "END")
            {
                finalCode += " " + code;
                code = Console.ReadLine();
            }

            ExtractHyperLinkText(finalCode);
        }


        //Extracts the hyperlink text from the code.
        public static void ExtractHyperLinkText(string finalCode)
        {
            var hyperLinkText = string.Empty;
            var temp = finalCode.Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in temp.Where(x => x.Contains("href")).Where(y => y.Contains("a ")))
            {
                if (item.Contains("href=") && !item.Contains('&'))
                {
                    hyperLinkText = item.Substring(item.IndexOf("href=") + 5);
                }
                else if (item.Contains("href =") && !item.Contains('&'))
                {
                    hyperLinkText = item.Substring(item.IndexOf("href =") + 6);
                }

                hyperLinkText = hyperLinkText.Trim();

                if (hyperLinkText.StartsWith("\""))
                {
                    hyperLinkText = hyperLinkText.TrimStart('"');

                    if (hyperLinkText.Contains("\""))
                    {
                        hyperLinkText = hyperLinkText.Substring(0, hyperLinkText.IndexOf('"'));
                    }
                }
                else if (hyperLinkText.StartsWith("\'"))
                {
                    hyperLinkText = hyperLinkText.TrimStart('\'');
                    hyperLinkText = hyperLinkText.Substring(0, hyperLinkText.IndexOf('\''));
                }
                else if (hyperLinkText.Contains(" "))
                {
                    hyperLinkText = hyperLinkText.Substring(0, hyperLinkText.IndexOf(' '));
                }

                if (hyperLinkText != string.Empty)
                {
                    Console.WriteLine(hyperLinkText);
                }

                hyperLinkText = string.Empty;
            }
        }
    }
}