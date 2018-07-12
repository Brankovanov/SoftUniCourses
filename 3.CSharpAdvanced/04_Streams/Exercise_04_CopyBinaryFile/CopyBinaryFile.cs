using System;
using System.IO;

namespace Exercise_04_CopyBinaryFile
{
    public class CopyBinaryFile
    {
        public static void Main(string[] args)
        {
            CreateCopy();
            Console.WriteLine("Copy complete.");
        }

        //Copies the given file.
        public static void CreateCopy()
        {
            var sourceCat = new FileStream("../../Cat.jpg", FileMode.Open);
            var destinationCat = new FileStream("../../copyCat.jpg", FileMode.Create);

            using (sourceCat)
            {
                using (destinationCat)
                {
                    var buffer = new byte[1024 * 1024];
                    var readBytes = sourceCat.Read(buffer, 0, buffer.Length);

                    while (readBytes != 0)
                    {
                        destinationCat.Write(buffer, 0, readBytes);
                        readBytes = sourceCat.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}