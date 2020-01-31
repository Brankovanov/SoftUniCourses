using System;
using System.IO;

namespace Lab_02_LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader(@"../../../input.txt");
            using var writer = new StreamWriter(@"../../../output.txt");

            Read(reader, writer);
        }

        private static void Read(StreamReader reader, StreamWriter writer)
        {
            var counter = 1;
            var line = string.Empty;
            var modified = string.Empty;

            while (true)
            {
                line = reader.ReadLine();
                modified = $"{counter}. {line}";

                Write(writer, modified);


                if (line == null)
                {
                    break;
                }

                counter++;
            }
        }

        private static void Write(StreamWriter writer, string modified)
        {
            writer.WriteLine(modified);
        }
    }
}
