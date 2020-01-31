using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_05_CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveText();
        }

        private static void ReceiveText()
        {
            var text = Console.ReadLine().ToCharArray();

            CountSymbol(text);
        }

        private static void CountSymbol(char[] text)
        {
            var symbols = new Dictionary<char, int>();

            foreach(var ch in text)
            {
                if(symbols.ContainsKey(ch))
                {
                    symbols[ch]++;
                }
                else
                {
                    symbols.Add(ch, 1);
                }
            }

            PrintSymbols(symbols);
        }

        private static void PrintSymbols(Dictionary<char, int> symbols)
        {
            foreach(var ch in symbols.OrderBy(ch=>ch.Key))
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
