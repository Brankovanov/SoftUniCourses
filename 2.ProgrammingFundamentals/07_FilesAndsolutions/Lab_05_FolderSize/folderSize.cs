using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_FolderSize
{
    class folderSize
    {
        static void Main(string[] args)
        {
            MeasureFolder();
        }

        //Измерва размера на файловете в директорията.
        static void MeasureFolder()
        {
            var totalSize = 0.0;
            string[] filesInTheFolder = Directory.GetFiles("../../TestFolder");

            foreach(var file in filesInTheFolder)
            {
                FileInfo size =new FileInfo(file);
                totalSize += size.Length;
            }

            totalSize = totalSize / 1024 / 1024;
            CreateOutput(totalSize);
        }

        //Създава файл, който да съдържа отговора.
        static void CreateOutput(double totalSize)
        {
            File.WriteAllText("output.txt", totalSize.ToString());
            PrintOutput();
        }

        //Принтира отговора от файл.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("output.txt"));
        }
    }
}
