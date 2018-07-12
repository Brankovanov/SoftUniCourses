using System;
using System.IO;

namespace Lab_04_CopyFile
{
    public class CopyFile
    {
        public static void Main(string[] args)
        {
            CreateCopy();
            Console.WriteLine("Copy complete.");
        }

        //Creates copy of the given file.
        public static void CreateCopy()
        {
            var source = new FileStream("../../copyMe.png", FileMode.Open);
            var destination = new FileStream("../../copy.png", FileMode.Create);

            using (source)
            {
                var buffer = new byte[1024 * 1024];
                int readBytes = source.Read(buffer, 0, buffer.Length);

                using (destination)
                {
                    while (readBytes != 0)
                    {
                        destination.Write(buffer, 0, readBytes);
                        readBytes = source.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}