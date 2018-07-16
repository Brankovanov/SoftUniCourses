using System;
using System.Linq;

namespace Lab_02_URLParse
{
    public class URLParse
    {
        public static void Main(string[] args)
        {
            ReceiveURL();
        }

        //Receives URL from the console.
        public static void ReceiveURL()
        {
            var url = Console.ReadLine();
            ParseUrl(url);
        }

        //Parces the url.
        public static void ParseUrl(string url)
        {
            var temp = url.Split(new string[] { "://" }, StringSplitOptions.None);
            var innerTemp = temp[1].Split('/');

            if (url.IndexOf("://") == url.LastIndexOf("://") && temp.Length == 2 && innerTemp.Length > 2)
            {
                var protocol = temp[0];
                var server = innerTemp[0];
                var resources = temp[1].Replace(server + "/", string.Empty);

                if (resources.Contains("/"))
                {
                    Print(resources, protocol, server);
                }
                else
                {
                    Console.WriteLine("Invalid URL");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid URL");
                return;
            }
        }

        //Prints the valid urls.
        public static void Print(string resources, string protocol, string server)
        {
            Console.WriteLine("Protocol = " + protocol);
            Console.WriteLine("Server = " + server);
            Console.WriteLine("Resources = " + resources);
        }
    }
}