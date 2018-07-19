using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_11_SemanticHtml
{
    public class SemanticHtml
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive inputs from the console.
        public static void ReceiveInput()
        {
            var html = Console.ReadLine();
            var htmlCode = new StringBuilder();

            while (html != "END")
            {
                htmlCode.AppendLine(html);
                html = Console.ReadLine();
            }

            RedactCode(htmlCode);
        }

        //Redacts the code.
        public static void RedactCode(StringBuilder htmlCode)
        {
            var nonSemanticPattern = new Regex("((<div)|(</div>)).+");
            var nonSemanticList = nonSemanticPattern.Matches(htmlCode.ToString());
            var semanticTag = string.Empty;

            foreach (Match nonSemanticTag in nonSemanticList)
            {
                var token = nonSemanticTag.ToString();

                if (token.Contains("<div"))
                {
                    semanticTag = RedactUpperTag(token);
                }
                else if (token.Contains("!"))
                {
                    semanticTag = RedactLowerTag(token);
                }

                if (semanticTag.Contains(" >"))
                {
                    semanticTag = semanticTag.Replace(" >", ">");
                }

                htmlCode = htmlCode.Replace(token.ToString(), semanticTag);
            }

            PrintSemanticHtml(htmlCode);
        }

        //Redacts the nonsemantic upper tags.
        public static string RedactUpperTag(string token)
        {
            if (token.Contains("main"))
            {
                token = token.Replace("<div", "<main");

                if (token.Contains(" id=\"main\""))
                {
                    token = token.Replace(" id=\"main\"", string.Empty);
                }
                else if (token.Contains(" id = \"main\""))
                {
                    token = token.Replace(" id = \"main\"", string.Empty);
                }

                if (token.Contains("class=\"main\""))
                {
                    token = token.Replace(" class=\"main\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("header"))
            {
                token = token.Replace("<div", "<header");

                if (token.Contains(" id=\"header\""))
                {
                    token = token.Replace(" id=\"header\"", string.Empty);
                }
                else if (token.Contains(" id = \"header\""))
                {
                    token = token.Replace(" id = \"header\"", string.Empty);
                }

                if (token.Contains("class=\"header\""))
                {
                    token = token.Replace(" class=\"header\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("nav"))
            {
                token = token.Replace("<div", "<nav");

                if (token.Contains(" id=\"nav\""))
                {
                    token = token.Replace(" id=\"nav\"", string.Empty);
                }
                else if (token.Contains(" id = \"nav\""))
                {
                    token = token.Replace(" id = \"nav\"", string.Empty);
                }

                if (token.Contains("class=\"nav\""))
                {
                    token = token.Replace(" class=\"nav\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("article"))
            {
                token = token.Replace("<div", "<article");

                if (token.Contains(" id=\"article\""))
                {
                    token = token.Replace(" id=\"article\"", string.Empty);
                }
                else if (token.Contains(" id = \"article\""))
                {
                    token = token.Replace(" id = \"article\"", string.Empty);
                }

                if (token.Contains("class=\"article\""))
                {
                    token = token.Replace(" class=\"article\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("section"))
            {
                token = token.Replace("<div", "<section");

                if (token.Contains(" id=\"section\""))
                {
                    token = token.Replace(" id=\"section\"", string.Empty);
                }
                else if (token.Contains(" id = \"section\""))
                {
                    token = token.Replace(" id = \"section\"", string.Empty);
                }

                if (token.Contains("class=\"section\""))
                {
                    token = token.Replace(" class=\"section\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("aside"))
            {
                token = token.Replace("<div", "<aside");

                if (token.Contains(" id=\"aside\""))
                {
                    token = token.Replace(" id=\"aside\"", string.Empty);
                }
                else if (token.Contains(" id = \"aside\""))
                {
                    token = token.Replace(" id = \"aside\"", string.Empty);
                }

                if (token.Contains("class=\"aside\""))
                {
                    token = token.Replace(" class=\"aside\"", string.Empty);
                }

                return token;
            }
            else if (token.Contains("footer"))
            {
                token = token.Replace("<div", "<footer");

                if (token.Contains(" id=\"footer\""))
                {
                    token = token.Replace(" id=\"footer\"", string.Empty);
                }
                else if (token.Contains(" id = \"footer\""))
                {
                    token = token.Replace(" id = \"footer\"", string.Empty);
                }

                if (token.Contains("class=\"footer\""))
                {
                    token = token.Replace(" class=\"footer\"", string.Empty);
                }

                return token;
            }

            return string.Empty;
        }

        //Redacts the nonsemantic lower tags.
        public static string RedactLowerTag(string token)
        {
            if (token.Contains("main"))
            {
                return "</main>";
            }
            else if (token.Contains("header"))
            {
                return "</header>";
            }
            else if (token.Contains("nav"))
            {
                return "</nav>";
            }
            else if (token.Contains("article"))
            {
                return "</article>";
            }
            else if (token.Contains("section"))
            {
                return "</section>";
            }
            else if (token.Contains("aside"))
            {
                return "</aside>";
            }
            else if (token.Contains("footer"))
            {
                return "</footer>";
            }

            return string.Empty;
        }

        //Prints the semantic html code.
        public static void PrintSemanticHtml(StringBuilder htmlCode)
        {
            Console.WriteLine(htmlCode);
        }
    }
}