using System;
using System.IO;

namespace Lab_01_OddLines
{
    public class oddLines
    {
        public static void Main(string[] args)
        {
            SortText();
        }

        //Сортира одаден текст от файл.
        static void SortText()
        {
            string[] tempList = File.ReadAllLines("./textToSort.txt");
            CreateFinalFile(tempList);
        }

        //Създава нов файл с редактирано съдържание.
        static void CreateFinalFile(string[] tempList)
        {
            try
            {
                File.Delete("./finalText.txt");

                for (var index = 1; index <= tempList.Length - 1; index = index + 2)
                {
                    File.AppendAllText("./finalText.txt", tempList[index] + "\r\n");
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            finally
            {
                PrintFinalText();
            }
        }

        //Отпечатва на конзолата финалната версия на редактирания текст.
        static void PrintFinalText()
        {
            Console.WriteLine(File.ReadAllText("./finalText.txt"));
        }
    }
}
