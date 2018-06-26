using System;
using System.Collections.Generic;

namespace _01.BashSoft
{
    public class OutputWriter
    {
        //Prints the output message on the console.
        public static void WriteMessage(string message)
        {
            Console.Write(message);
        }

        //Prints the output message on a new line on the console.
        public static void WriteMessageOnAnewLine(string message)
        {
            Console.WriteLine(message);
        }

        //Prints an empty line. 
        public static void WriteEmptyLine()
        {
            Console.WriteLine();
        }

        //Prints an error message when exception occurs.
        public static void DisplayExceotions(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }

        //Prints student information.
        public static void PrintStudent(KeyValuePair<string, List<int>> student)
        {
            OutputWriter.WriteMessageOnAnewLine(string.Format($"{student.Key} - {string.Join(", ", student.Value)}"));
        }
    }
}