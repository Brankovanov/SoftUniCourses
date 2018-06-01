using System;
using System.IO;

namespace Lab_02_LiveNumbers
{
    public class liveNumbers
    {
        public static void Main(string[] args)
        {
            SortText();
        }

        //Сортира одаден текст от файл.
        static void SortText()
        {
            string[] tempList = File.ReadAllLines("./textToEdit.txt");
            CreateFinalFile(tempList);
        }

        //Създава нов файл с редактирано съдържание.
        static void CreateFinalFile(string[] tempList)
        {
            try
            {
                File.Delete("./finalText.txt");

                for (var index = 1; index <= tempList.Length; index++)
                {
                    File.AppendAllText("./finalText.txt", index.ToString() + ". " + tempList[index] + "\r\n");
                }
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

