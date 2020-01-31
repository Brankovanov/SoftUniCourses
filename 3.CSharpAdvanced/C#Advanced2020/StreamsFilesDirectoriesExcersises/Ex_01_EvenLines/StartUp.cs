using System;
using System.IO;
using System.Linq;

namespace Ex_01_EvenLines
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CreateReader();
        }

        private static void CreateReader()
        {
            using var reader = new StreamReader("../../../text.txt");

            ReadFile(reader);
        }

        private static void ReadFile(StreamReader reader)
        {
            var lineNumber = 0;
            var line = string.Empty;

            while (line != null)
            {

                line = reader.ReadLine();

                if (lineNumber % 2 == 0)
                {
                    line = ModifyLine(line);
                    Print(line);
                }

                lineNumber++;
            }
        }

        private static void Print(string line)
        {
            Console.WriteLine(line);
        }

        private static string ModifyLine(string line)
        {
            var toReplace = new char[] { '-', ',', '.', '!', '?' };
            line = string.Join(' ',line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@')
                .Split(new char[] { ' ' },StringSplitOptions.None)
                .Reverse());

            return line;
        }
    }
}
