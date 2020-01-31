using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_03_WordCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using var wordReader = new StreamReader(@"../../../words.txt");
            using var textReader = new StreamReader(@"../../../text.txt");
            using var writer = new StreamWriter(@"../../../output.txt");

            Read(wordReader, writer,textReader);
        }

        private static void Read(StreamReader wordReader, StreamWriter writer, StreamReader textReader)
        {
            var line = string.Empty;
            var dictionary = new Dictionary<string, int>();

            while (true)
            {
                line = wordReader.ReadLine();

                if (line == null)
                {
                    break;
                }

                var words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach(var word in words)
                {
                    if(!dictionary.ContainsKey(word))
                    {
                        dictionary.Add(word, 0);
                    }
                }                     
            }

            CountWords(dictionary, textReader, writer);
        }

        private static void CountWords(Dictionary<string,int> dictionary, StreamReader textReader, StreamWriter writer)
        {
            var line = string.Empty;
            var temp = new List<string>();

            while (true)
            {
                line = textReader.ReadLine();

                if (line == null)
                {
                    break;
                }

                temp.AddRange(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                foreach(var w in temp)
                {
                    if(dictionary.ContainsKey(w.ToLower().Trim('-')))
                    {
                        dictionary[w.ToLower().Trim('-')]++;
                    }
                }
            }

            Write(dictionary, writer);
        }

        private static void Write(Dictionary<string, int> dictionary, StreamWriter writer)
        {
            foreach(var entry in dictionary)
            {
                writer.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }
    }
}
