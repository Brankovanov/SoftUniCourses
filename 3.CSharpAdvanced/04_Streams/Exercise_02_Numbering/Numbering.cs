using System;
using System.IO;

namespace Exercise_02_Numbering
{
    public class Numbering
    {
        public static void Main(string[] args)
        {
            Reading();
            Console.WriteLine("Numbering complete.");
        }

        //Reads the lines from the text.txt file.
        public static void Reading()
        {
            var fileReader = new StreamReader("../../text.txt");
            var lineWriter = new StreamWriter("numbered.txt");

            using (fileReader)
            {
                using (lineWriter)
                {
                    var line = fileReader.ReadLine();
                    var numbers = 1;

                    while (line != null)
                    {
                        AddNumbering(line, numbers, lineWriter);
                        numbers++;
                        line = fileReader.ReadLine();
                    }
                }
            }
        }

        //Adds numbering to the lines.
        public static void AddNumbering(string line, int numbers, StreamWriter lineWriter)
        {
            line = $"Line {numbers}. {line}";
            WriteDown(line, lineWriter);
        }

        //Writes down the numbered lines on the file numbered.txt.
        public static void WriteDown(string line,StreamWriter lineWriter)
        {
            lineWriter.WriteLine(line);
        }
    }
}