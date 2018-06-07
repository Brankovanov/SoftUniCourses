using System;
using System.Collections.Generic;

namespace Exercise_07_QueryMess
{
    public class queryMess
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        // Получава вход от конзолата.
        static void ReceiveInput()
        {
            var line = string.Empty;

            while (line != "END")
            {
                line = Console.ReadLine();
                RemakeLine(line);
            }
        }

        //Редактира редовете според изискванията.
        static void RemakeLine(string line)
        {
            if (!line.Equals("END"))
            {
                var pairs = line.Split('&', '?');
                Dictionary<string, List<string>> keyValues = new Dictionary<string, List<string>>();
                var keyDict = string.Empty;
                var valueDict = string.Empty;
                foreach (var pair in pairs)
                {
                    if (pair.Contains("="))
                    {
                        var splittedPair = pair.Replace("+", " ").Replace("%20", " ").Split('=');
                        keyDict = splittedPair[0].Trim();
                        valueDict = splittedPair[1].Trim();

                        if (!keyValues.ContainsKey(keyDict))
                        {
                            keyValues[keyDict] = new List<string>();
                            keyValues[keyDict].Add(valueDict);
                        }
                        else
                        {
                            keyValues[keyDict].Add(valueDict);
                        }

                        keyDict = string.Empty;
                        valueDict = string.Empty;
                    }
                }
                PrintKeyValuePairt(keyValues);
                keyValues.Clear();

            }
        }

        //Отпечатва сортираните данни.
        static void PrintKeyValuePairt(Dictionary<string, List<string>> keyValues)
        {
            var output = string.Empty;
            foreach (var key in keyValues)
            {
                output+=key.Key + "=[";

                foreach (var value in key.Value)
                {
                    output+=value+", ";
                }

                output = output.Remove(output.Length - 2, 2);
                output += "]";
                Console.Write(output);
                output = string.Empty;
                
            }

            Console.WriteLine();
            
        }
    }
}