using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise_06_TraverseDirectory
{
    public class TraverseDirectory
    {
        public static void Main(string[] args)
        {
            var command = Console.ReadLine();

            if (command == "Start")
            {
                GetFileInformation();
            }
        }

        //Retrieves the names of the files in the given directory.
        public static void GetFileInformation()
        {
            var fileInformation = new SortedDictionary<string, SortedDictionary<string, float>>();
            var fileNames = Directory.GetFiles("../../");

            foreach (var file in fileNames)
            {
                var extension = Path.GetExtension(file);   
                var size = new FileInfo(file).Length/1000f;

                if (fileInformation.ContainsKey(extension) && !fileInformation[extension].ContainsKey(file))
                {
                    fileInformation[extension].Add(file.Replace("../../", "--"), size);
                }
                else if (!fileInformation.ContainsKey(extension))
                {
                    fileInformation.Add(extension, new SortedDictionary<string, float>());
                    fileInformation[extension].Add(file.Replace("../../", "--"), size);
                }
            }

            WriteDown(fileInformation);

        }

        //Writes down the information for the files on a .txt file.
        public static void WriteDown(SortedDictionary<string,SortedDictionary<string,float>>fileInformation)
        {
            var writer = new FileStream("../../fileLog.txt", FileMode.Create);
            writer.Close();

            foreach (var file in fileInformation.OrderByDescending(x=>x.Value.Count))
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
                        byte[] bytes = Encoding.UTF8.GetBytes(item.Key +" - "+ item.Value.ToString() +"kb" + Environment.NewLine);
                        writer.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }
    }
}