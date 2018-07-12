using System;
using System.IO;

namespace Exercise_01_OddLines
{
    public class OddLines
    {
        public static void Main(string[] args)
        {
            ReadTheTextFromFile();
        }

        //Reads the odd lines from the given file.
        static void ReadTheTextFromFile()
        {
            using (StreamReader reader = new StreamReader("../../text.txt"))
            {
                var oddLine = reader.ReadLine();
                var count = 1;

                while (oddLine != null)
                {
                    if (count % 2 == 0)
                    {
                        Print(oddLine);
                    }

                    count++;
                    oddLine = reader.ReadLine();
                }
            }
        }

        //Prints the odd lines from the file.
        static void Print(string oddLine)
        {
            Console.WriteLine(oddLine);
        }
    }
}