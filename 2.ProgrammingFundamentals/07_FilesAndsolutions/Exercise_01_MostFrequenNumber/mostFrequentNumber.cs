using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_01_MostFrequenNumber
{
    public class mostFrequentNumber
    {
        public static void Main(string[] args)
        {
            ProccessInputFile();
        }

        //Получава и обработва информацията от файл input.txt.
        static void ProccessInputFile()
        {
            List<int> numberArray = new List<int>();          
            var inputArray = File.ReadAllLines("./input.txt");
            File.Delete("./output.txt");

            foreach (var input in inputArray)
            {
                numberArray = input.Split(' ').Select(x => int.Parse(x)).ToList();
                CompareNumbers(numberArray);
                numberArray.Clear();
            }

            PrintOutput();      
        }

        //Сравнява числата в поредиците зададени във файл input.txt.
        static void CompareNumbers(List<int> numberArray)
        {
            var counter = 0;
            var finalCount = 0;
            var answer = 0;

            for (var index = 0; index <= numberArray.Count - 1; index++)
            {
                for (var innerIndex = 0; innerIndex <= numberArray.Count - 1; innerIndex++)
                {
                    if (numberArray[index] == numberArray[innerIndex])
                    {
                        counter++;
                    }
                }

                if (counter > finalCount)
                {
                    finalCount = counter;
                    counter = 0;
                    answer = int.Parse(numberArray[index].ToString());
                }
                else if (counter <= finalCount)
                {
                    counter = 0;
                }
            }

            CreateOutputFile(answer);
        }

        //Създава файл output.txt.
        static void CreateOutputFile(int answer)
        {
            File.AppendAllText("./output.txt", answer.ToString() + "\r\n");
        }

        //Принтира съдържанието на файл output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));          
        }
    }
}

