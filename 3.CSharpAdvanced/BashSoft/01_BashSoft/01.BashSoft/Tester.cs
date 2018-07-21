using System;
using System.IO;

namespace _01.BashSoft
{
    public static class Tester
    {
        //Reads the output from the compiled file and the expected output.
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnAnewLine("Reading files...");

            try
            {
                var mismatchPath = GetMismatchPath(expectedOutputPath);
                var actualOutputLines = File.ReadAllLines(userOutputPath);
                var expectedOutputLines = File.ReadAllLines(expectedOutputPath);
                bool hasMismatch;
                var mismatches = GetLinesWithPossibleMismathces(actualOutputLines, expectedOutputLines, out hasMismatch);

                PrintOutput(mismatches, hasMismatch, mismatchPath);
                OutputWriter.WriteMessageOnAnewLine("Files read!");
            }
            catch
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.InvalidPath);
            }
        }

        //Finds the path to Mismatched.txt.
        private static string GetMismatchPath(string expectedOutputPath)
        {
            var indexOf = expectedOutputPath.LastIndexOf('\\');
            var directoryPath = expectedOutputPath.Substring(0, indexOf);
            var finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }

        //Compares the generated file with the expected file. 
        private static string[] GetLinesWithPossibleMismathces(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismath)
        {
            hasMismath = false;
            var output = string.Empty;
            var minOutputLInes = actualOutputLines.Length;

            OutputWriter.WriteMessageOnAnewLine("Compare files...");

            if (actualOutputLines.Length != expectedOutputLines.Length)
            {
                hasMismath = true;
                minOutputLInes = Math.Min(actualOutputLines.Length, expectedOutputLines.Length);
                OutputWriter.DisplayExceotions(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            var mismatches = new string[minOutputLInes];

            for (var index = 0; index < minOutputLInes; index++)
            {
                var actualLine = actualOutputLines[index];
                var expectedLine = expectedOutputLines[index];

                if (actualLine.Equals(expectedLine))
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }
                else
                {
                    output = string.Format("Mismatch at line {0} -- expected: \"{1}\", actual: \"{2}\"", index, expectedLine, actualLine);
                    output += Environment.NewLine;
                    hasMismath = true;
                }

                mismatches[index] = output;
            }

            return mismatches;
        }

        //Prints the output on the console.
        private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnAnewLine(line);
                }

                try
                {
                    File.WriteAllLines(mismatchPath, mismatches);
                }
                catch(DirectoryNotFoundException)
                {
                    OutputWriter.DisplayExceotions(ExceptionMessages.InvalidPath);
                }

                return;
            }
            else
            {
                OutputWriter.WriteMessageOnAnewLine("Files are identical. There are no mismatches.");
            }
        }
    }
}