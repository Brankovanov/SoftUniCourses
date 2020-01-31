using System;
using System.Collections.Generic;
using System.IO;

namespace Ex_02_LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReadFile();
        }

        private static void ReadFile()
        {
            var line = new List<string>();

            line.AddRange(File.ReadAllLines("../../../text.txt"));

            Modify(line);
        }

        private static void Modify(List<string> line)
        {
            var counter = 1;
            var counters = new int[2];

            for (var l = 0; l < line.Count; l++)
            {
                CountSymbols(line[l], counters);

                line[l] = $"Line {counter} {line[l]}({counters[0]})({counters[1]})";
                counter++;
            }

            PrintFile(line);
        }

        private static void PrintFile(List<string> line)
        {
           
            File.WriteAllText("../../../output.txt",string.Join(Environment.NewLine,line));
        }

        private static void CountSymbols(string v, int[] counters)
        {
            var letterCounter = 0;
            var punctuationCounter = 0;

            foreach (var ch in v)
            {
                if (Char.IsLetter(ch))
                {
                    letterCounter++;
                }
                else if (Char.IsPunctuation(ch))
                {
                    punctuationCounter++;
                }
            }

            counters[0] = letterCounter;
            counters[1] = punctuationCounter;
        }
    }
}
