using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab_04_MergeFiles
{
    public class mergeFiles
    {
        public static void Main(string[] args)
        {
            ReceiveElements();
        }

        //Взима елементите на двата файла, който трябва дасе слеят и ги записва в масив.
        static void ReceiveElements()
        {
            List<string> elements = File.ReadAllLines("./firstFile.txt").ToList();
            elements.AddRange(File.ReadAllLines("./secondFile.txt").ToList());
            elements = elements.OrderBy(x => x).ToList();
            CreateMerge(elements);
        }

        //Създава текстов файл, където съхранява съдържанието на двата оригинални файла.
        static void CreateMerge(List<string> elements)
        {
            File.WriteAllLines("./merged.txt", elements);
            PrintMerge();
        }

        //Принтира създържанието на финалния файл.
        static void PrintMerge()
        {
            Console.WriteLine(File.ReadAllText("./merged.txt"));
        }
    }
}
