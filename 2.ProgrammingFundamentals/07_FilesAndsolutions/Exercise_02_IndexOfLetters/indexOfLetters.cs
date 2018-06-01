using System;
using System.IO;

namespace Exercise_02_IndexOfLetters
{
    public class indexOfLetters
    {
        public static void Main(string[] args)
        {
            ProccessInputFile();
        }

        //Приема вход от файла input.txt.
        static void ProccessInputFile()
        {
            var input = File.ReadAllLines("./input.txt");

            foreach (var line in input)
            {
                FindIndex(line);
            }
        }

        //Обработва символите от вода и намира съответсващите индекси.
        static void FindIndex(string line)
        {
            File.Delete("./output");
            string[] alphabetArray = File.ReadAllLines("./alphabet.txt");

            foreach (var symbol in line)
            {
                for (var index = 0; index <= alphabetArray.Length - 1; index++)
                {
                    if (symbol.ToString().Equals(alphabetArray[index]))
                    {
                        CreateOutput(symbol, index);
                    }
                }
            }

            PrintOutput();          
        }

        //Създава файл output.txt, където се съхранява изхода.
        static void CreateOutput(char symbol, int index)
        {
            File.AppendAllText("./output", symbol.ToString() + " -> " + index.ToString() + "\r\n");
        }

        //Принтира съдържанието на файл output.txt
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output"));
        }
    }
}