using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex_04_TraverseDir
{
    class StartUp
    {
        static void Main(string[] args)
        {
            TraverseDirectory();
        }

        private static void TraverseDirectory()
        {
            var sorted = new Dictionary<string, Dictionary<string, double>>();

            var directoryI = new DirectoryInfo(@"../../../");
            var fileInf = directoryI.GetFiles();

            foreach (var file in fileInf)
            {
                var name = file.Name;
                var extention = name.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[1];

                if (sorted.ContainsKey(extention))
                {
                    if (!sorted[extention].ContainsKey(name))
                    {
                        sorted[extention].Add(name, file.Length);
                    }

                }
                else
                {
                    sorted.Add(extention, new Dictionary<string, double>());
                    sorted[extention].Add(name, file.Length);
                }
            }

            PrintToFile(sorted);
        }

        private static void PrintToFile(Dictionary<string, Dictionary<string, double>> sorted)
        {
            using var writer = new StreamWriter("../../../report.txt");

            foreach (var ext in sorted.OrderByDescending(e => e.Value.Count).ThenBy(c => c.Key))
            {
                writer.WriteLine($".{ext.Key}");

                foreach (var f in ext.Value.OrderBy(fi=>fi.Value))
                {
                    writer.WriteLine($"--{f.Key} - {f.Value}kb");
                }
            }
        }
    }
}
