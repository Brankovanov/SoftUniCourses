using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise_08_Full_Directory_Traversal
{
    public class FullDirectoryTraversal
    {
        public static void Main(string[] args)
        {
            var command = Console.ReadLine();

            if (command == "Start")
            {
                GetFileInformation();
            }

            Console.WriteLine("Complete.");
        }

        //Retrieves the names of the files in the given directory.
        public static void GetFileInformation()
        {
            var fileInformation = new SortedDictionary<string, SortedDictionary<string, SortedDictionary<string, float>>>();
            var directories = Directory.GetDirectories("../../").ToList();

            for (var dir = 0; dir < directories.Count; dir++)
            {
                var sub = Directory.GetDirectories(directories[dir]);
                directories.AddRange(sub);
            }

            foreach (var directory in directories)
            {
                var fileNames = Directory.GetFiles(directory);

                if (!fileInformation.ContainsKey(directory.Replace("../../", "-")))
                {
                    fileInformation.Add(directory.Replace("../../", "-"), new SortedDictionary<string, SortedDictionary<string, float>>());
                }

                foreach (var file in fileNames)
                {
                    var extension = Path.GetExtension(file);
                    var size = new FileInfo(file).Length / 1000f;

                    if (!fileInformation[directory.Replace("../../", "-")].ContainsKey("--" + extension))
                    {
                        fileInformation[directory.Replace("../../", "-")].Add("--" + extension, new SortedDictionary<string, float>());
                    }

                    if (!fileInformation[directory.Replace("../../", "-")]["--" + extension].ContainsKey("---" + file.Remove(0, file.LastIndexOf('\\') + 1)))
                    {
                        fileInformation[directory.Replace("../../", "-")]["--" + extension].Add("---" + file.Remove(0, file.LastIndexOf('\\') + 1), size);
                    }
                }
            }

            WriteDown(fileInformation);
        }

        //Writes down the information for the files on a .txt file.
        public static void WriteDown(SortedDictionary<string, SortedDictionary<string, SortedDictionary<string, float>>> fileInformation)
        {
            var writer = new FileStream("../../fileLog.txt", FileMode.Create);
            writer.Close();

            foreach (var directory in fileInformation.OrderByDescending(x => x.Value.Count))
            {
                writer = new FileStream("../../fileLog.txt", FileMode.Append);

                using (writer)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(directory.Key + Environment.NewLine);
                    writer.Write(bytes, 0, bytes.Length);
                }

                foreach (var file in directory.Value)
                {
                    writer = new FileStream("../../fileLog.txt", FileMode.Append);

                    using (writer)
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(file.Key + Environment.NewLine);
                        writer.Write(bytes, 0, bytes.Length);
                    }

                    foreach (var item in file.Value)
                    {
                        writer = new FileStream("../../fileLog.txt", FileMode.Append);

                        using (writer)
                        {
                            byte[] bytes = Encoding.UTF8.GetBytes(item.Key + " - " + item.Value.ToString() + "kb" + Environment.NewLine);
                            writer.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
        }
    }
}