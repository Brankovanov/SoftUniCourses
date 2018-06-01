using System;
using System.IO;
using System.Linq;

namespace Exercise_03_EqualSums
{
    public class equalSums
    {
        public static void Main(string[] args)
        {
            ProccessInput();
        }

        //Обработва входна информация от файл input.txt.
        static void ProccessInput()
        {       
            var inputArray = File.ReadAllLines("./input.txt");
            File.Delete("./output.txt");

            foreach (var line in inputArray)
            {
                CreateArray(line);
            }

            PrintOutput();
        }

        //Създава масив с числа от всеки отделен ред от файла input.txt.
        static void CreateArray(string line)
        {
            var intArray = line.Split(' ').Select(x => int.Parse(x)).ToArray();
            FindSums(intArray);
        }

        //Открива еднаквите суми.
        static void FindSums(int[] intArray)
        {
            var answer = 0;
            var leftSum = 0;
            var rightSum = 0;
            var counter = 0;

            for (var index = 0; index <= intArray.Length - 1; index++)
            {
                answer = index;

                for (var leftIndex = index - 1; leftIndex >= 0; leftIndex--)
                {
                    leftSum += intArray[leftIndex];
                }

                for (var rightIndex = index + 1; rightIndex <= intArray.Length - 1; rightIndex++)
                {
                    rightSum += intArray[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    counter++;
                    leftSum = 0;
                    rightSum = 0;
                    CreateOutputSum(answer);
                    answer = 0;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                    answer = 0;
                }
            }

            if (counter == 0)
            {
                CreateOutputNoSum();
            }
        }

        //Добавя отговор във файла output.txt ако има открити еднакви суми.
        static void CreateOutputSum(int answer)
        {
            File.AppendAllText("./output.txt", answer.ToString() + "\r\n");
        }

        //Добава отговор във файла output.txt ако няма открити еднакви суми.
        static void CreateOutputNoSum()
        {
            File.AppendAllText("./output.txt", "no" + "\r\n");
        }

        //Принтира информацията във файла output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
        }
    }
}
