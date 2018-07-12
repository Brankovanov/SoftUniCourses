using System;
using System.IO;
using System.Linq;

namespace Lab_02_WriteToFile
{
    public class WriteToFile
    {
        public static void Main(string[] args)
        {
            ReadFile();
        }

        //Reads from the file WriteToFile.cs.
        public static void ReadFile()
        {
            StreamReader codeReader = new StreamReader("../../WriteToFile.cs");
            StreamWriter writer = new StreamWriter("reversedText.txt");

            using (codeReader)
            {
                using (writer)
                {
                    var line = codeReader.ReadLine();

                    while (line != null)
                    {
                        ReverseLine(line, writer);
                        line = codeReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Reversal complete.");
        }

        //Reverses the lines read from file WriteToFile.cs.
        public static void ReverseLine(string line, StreamWriter writer)
        {
            var reversedLine = string.Join("", line.Reverse());
            WriteLine(reversedLine, writer);
        }

        //Writes the reversed lin on the reversedText.txt.
        public static void WriteLine(string reversedLine, StreamWriter writer)
        {                      
                writer.WriteLine(reversedLine);            
        }
    }
}