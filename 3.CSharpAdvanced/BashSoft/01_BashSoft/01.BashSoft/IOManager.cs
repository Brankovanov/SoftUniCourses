using System;
using System.Collections.Generic;
using System.IO;

namespace _01.BashSoft
{
    public class IOManager
    {
        //Traverse through all the subdirectories of a directory by Breadth-first search algoritm.
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            var initialIndentation = SessionData.currentPath.Split('\\').Length;
            var subFolder = new Queue<string>();
            subFolder.Enqueue(SessionData.currentPath);

            while (subFolder.Count != 0)
            {
                var message = subFolder.Peek();
                var currentPath = subFolder.Dequeue();
                int indentation = currentPath.Split('\\').Length - initialIndentation;

                if (depth - indentation < 0)
                {
                    break;
                }

                OutputWriter.WriteMessageOnAnewLine(string.Format("{0}{1}", new string('-', indentation), currentPath));

                try
                {
                    foreach (var file in Directory.GetFiles(currentPath))
                    {
                        var indexOfLastSlash = file.LastIndexOf("\\");
                        var fileName = file.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnAnewLine(new string('-', indexOfLastSlash) + fileName);
                    }

                    foreach (var directoryPath in Directory.GetDirectories(currentPath))
                    {
                        subFolder.Enqueue(directoryPath);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    OutputWriter.DisplayExceotions(ExceptionMessages.UnauthorizedAccessExceptionMessage);
                }
            }
        }

        //Creates a directory for current sesion.
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            var path = Directory.GetCurrentDirectory() + "\\" + name;

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.ForbiddenSymbolsContainedInName);
            }
        }

        //Changes the relative path of current directory.
        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    var currentPath = SessionData.currentPath;
                    var indexOfLastSlash = currentPath.LastIndexOf("\\");
                    var newPath = currentPath.Substring(0, indexOfLastSlash);
                    SessionData.currentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    OutputWriter.DisplayExceotions(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
                }
            }
            else
            {
                var currentPath = SessionData.currentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        //Change the absolute path of the current directory
        public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.InvalidPath);
            }

            SessionData.currentPath = absolutePath;
        }
    }
}