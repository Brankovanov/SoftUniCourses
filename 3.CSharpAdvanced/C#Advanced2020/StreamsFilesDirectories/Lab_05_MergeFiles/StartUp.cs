using System;
using System.IO;

namespace Lab_05_MergeFiles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using var readerOne = new StreamReader(@"../../../inputOne.txt");
            using var readerTwo = new StreamReader(@"../../../inputTwo.txt");
            using var writer = new StreamWriter(@"../../../output.txt");

            Read(readerOne,readerTwo, writer);
        }

        private static void Read(StreamReader readerOne,StreamReader readerTwo, StreamWriter writer)
        {
            var line = string.Empty;

            while (true)
            {
                line = readerOne.ReadLine();
               
                    Write(writer, line);

                if (line == null)
                {
                    break;
                }
            }

            while (true)
            {
                line = readerTwo.ReadLine();

                Write(writer, line);

                if (line == null)
                {
                    break;
                }
            }
        }

        private static void Write(StreamWriter writer, string line)
        {
            writer.WriteLine(line);
        }
    }
}
