using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_09_QueryMess
{
    public class QueryMess
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive inputs from the console.
        public static void ReceiveInput()
        {
            var query = Console.ReadLine();

            while (query != "END")
            {
                ExtractQuery(query);
                query = Console.ReadLine();
            }
        }

        //Extracts the queries.
        public static void ExtractQuery(string query)
        {
            var querryDictionary = new Dictionary<string, List<string>>();
            var querryPattern = new Regex("[^&\\?]+");
            var queries = querryPattern.Matches(query);

            foreach (var q in queries)
            {
                if (q.ToString().Contains("="))
                {
                    var temp = q.ToString().Replace('+', ' ');
                    temp = temp.Replace("%20", " ");
                    var token = temp.Split('=');

                    if (!querryDictionary.ContainsKey(token[0].Trim()))
                    {
                        querryDictionary.Add(token[0].Trim(), new List<string>());
                    }

                    querryDictionary[token[0].Trim()].Add(token[1].Trim());
                }
            }

            Print(querryDictionary);
        }

        //Prints the final querries.
        public static void Print(Dictionary<string, List<string>> querryDictionary)
        {
            foreach (var dictKey in querryDictionary)
            {
                Console.Write(dictKey.Key + "=");
                Console.Write("[" + string.Join(", ", dictKey.Value) + "]");
            }

            Console.WriteLine();
        }
    }
}