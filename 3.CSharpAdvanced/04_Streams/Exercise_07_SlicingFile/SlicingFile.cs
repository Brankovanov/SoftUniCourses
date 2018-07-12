using System;
using System.IO;

namespace Exercise_07_SlicingFile
{
    public class SlicingFile
    {
        public static void Main(string[] args)
        {
            ReceiveFileInformation();
        }

        //Receives information about the file that have to be sliced.
        public static void ReceiveFileInformation()
        {
            var filePath = "../../sliceMe.mp4";
            var parts = int.Parse(Console.ReadLine());

            Slice(filePath, parts);
            Console.WriteLine("Split complete.");
            Assemble();
            Console.WriteLine("Assemble complete.");
        }

        //Slices the given file.
        public static void Slice(string filePath, int parts)
        {
            var spliter = new FileStream(filePath, FileMode.Open);

            using (spliter)
            {
                var partsLenght = spliter.Length / parts + 1;

                for (var index = 1; index <= parts; index++)
                {
                    var partDestination = $"../../destination/Part {index}";
                    var partCreator = new FileStream(partDestination, FileMode.Create);

                    using (partCreator)
                    {
                        var buffer = new byte[4069];

                        while (partCreator.Length < partsLenght)
                        {
                            var readBytes = spliter.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            partCreator.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        //Assembles the parts in to one file.
        public static void Assemble()
        {
            var directory = Directory.GetFiles("../../destination");
            var restored = new FileStream("../../destination/restored/restored.mp4", FileMode.Create);
            restored.Close();
            restored = new FileStream("../../destination/restored/restored.mp4", FileMode.Append);

            using (restored)
            {
                foreach (var file in directory)
                {
                    var filePartsPath = file.Replace('\\', '/');
                    var recombiner = new FileStream(filePartsPath, FileMode.Open);

                    using (recombiner)
                    {
                        var bytePart = new byte[4096];
                        var readBytes = recombiner.Read(bytePart, 0, bytePart.Length);

                        while (readBytes != 0)
                        {
                            restored.Write(bytePart, 0, bytePart.Length);
                            readBytes = recombiner.Read(bytePart, 0, bytePart.Length);
                        }
                    }
                }
            }
        }
    }
}