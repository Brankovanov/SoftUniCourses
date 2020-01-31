using System;
using System.IO;

namespace Lab_07_DirectorySize
{
    class StartUp
    {
        static void Main(string[] args)
        {     
            CalculateSize();
        }

        private static void CalculateSize()
        {
            var directory = Directory.GetFiles(".");
            var totalLength = 0m;

            foreach(var file in directory)
            {
                var fileInfo = new FileInfo(file);

                totalLength += fileInfo.Length;
            }

            Console.WriteLine(totalLength);
        }
    }
}
