using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_04_MaxSequenceOfEquelElements
{
    public class maxSequanceOfEqualElements
    {
        public static void Main(string[] args)
        {
            ProccessInputFile();
        }

        //Обработва файла input.txt. 
        static void ProccessInputFile()
        {
            var input = File.ReadAllLines("./input.txt");
            File.Delete("./output.txt");

            foreach (var line in input)
            {
                CreateArray(line);
            }

            PrintOutput();
        }

        //Създава масив, държащ редица от числа. 
        static void CreateArray(string input)
        {
            var mainArray = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            SortArray(mainArray);
        }

        //Сортира масива, държащ редиците от числа.
        static void SortArray(int[] mainArray)
        {
            var temporaryString = new List<int>();
            var finalString = new List<int>();

            for (var index = 0; index <= mainArray.Length - 2; index++)
            {
                if (mainArray[index + 1] == mainArray[index])
                {
                    temporaryString.Add(mainArray[index]);

                    if (index == mainArray.Length - 2)
                    {
                        if (finalString.Count >= temporaryString.Count)
                        {
                            temporaryString.RemoveRange(0, temporaryString.Count);
                        }
                        else if (finalString.Count < temporaryString.Count)
                        {
                            finalString.RemoveRange(0, finalString.Count);
                            finalString.AddRange(temporaryString);
                            temporaryString.RemoveRange(0, temporaryString.Count);
                        }
                    }
                }
                else
                {
                    if (finalString.Count >= temporaryString.Count)
                    {
                        temporaryString.RemoveRange(0, temporaryString.Count);
                    }
                    else if (finalString.Count < temporaryString.Count)
                    {
                        finalString.RemoveRange(0, finalString.Count);
                        finalString.AddRange(temporaryString);
                        temporaryString.RemoveRange(0, temporaryString.Count);
                    }
                }
            }

            finalString.Add(finalString[0]);
            CreateOutput(finalString);
        }

        //Създава файл output.txt.
        static void CreateOutput(List<int> finalString)
        {
            foreach (var ch in finalString)
            {
                File.AppendAllText("./output.txt", ch.ToString() + " ");
            }

            File.AppendAllText("./output.txt", "\r\n");
        }

        //Принтира файла output.txt.
        static void PrintOutput()
        {
            Console.Write(File.ReadAllText("./output.txt"));
        }
    }
}