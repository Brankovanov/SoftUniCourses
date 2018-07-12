using System;
using System.IO;

namespace Lab_01_ReadingFile
{
    public class ReadingFile
    {
        public static void Main(string[] args)
        {
            ReadLinesFromFile();
        }

        //Reads the lines from file.
        static void ReadLinesFromFile()
        {
            StreamReader reader = new StreamReader("../../text.txt");

            using (reader)
            {
                int numbering = 1;
                var line = reader.ReadLine();

                while (line != null)
                {
                    Print(line, numbering);
                    numbering++;
                    line = reader.ReadLine();
                }
            }
        }

        //Prints the lines read from the file.
        static void Print(string line, int numbering)
        {
            Console.WriteLine($"{numbering}. {line}");
        }
    }
}