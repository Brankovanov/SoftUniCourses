using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_12_Files
{
    public class files
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var listOfFiles = new List<string>();
            var numberOfFiles = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfFiles; index++)
            {
                listOfFiles.Add(Console.ReadLine());
            }

            var foldersToFind = Console.ReadLine();

            SortFiles(foldersToFind, listOfFiles);
        }

        //Find the files that suite the requirements
        static void SortFiles(string foldersToFind, List<string> listOfFiles)
        {
            var fileDictionary = new Dictionary<string, int>();
            var tempFilters = foldersToFind.Split(' ');
            var formatToFind = tempFilters[0];
            var rootToFind = tempFilters[2];

            foreach (var file in listOfFiles)
            {
                var roots = file.Split('\\', ';').Select(x => x.Trim()).ToList();
                var size = roots[roots.Count - 1];
                var fileName = roots[roots.Count - 2];
                roots.RemoveRange(roots.Count - 2, 2);

                if (roots[0] == rootToFind && fileName.Split('.').Contains(formatToFind) && !fileDictionary.ContainsKey(fileName))
                {
                    fileDictionary.Add(fileName, int.Parse(size));
                }
                else if (roots[0] == rootToFind && fileName.Contains(formatToFind) && fileDictionary.ContainsKey(fileName))
                {
                    fileDictionary[fileName] = int.Parse(size);
                }
            }

            Print(fileDictionary);
        }

        //Print the files that coresponds to the criterees.
        static void Print(Dictionary<string, int> fileDictionary)
        {
            if (fileDictionary.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in fileDictionary.OrderByDescending(f => f.Value).ThenBy(fn => fn.Key))
                {
                    Console.WriteLine(file.Key + " - " + file.Value + " KB");
                }
            }
        }
    }
}
