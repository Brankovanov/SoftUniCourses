using System.Diagnostics;

namespace _01.BashSoft
{
    public class CommandInterpreter
    {
        //Interprets the commands received from the console.
        public static void InterpretCommand(string input)
        {
            var data = input.Split(' ');
            var command = data[0];

            switch (command)
            {
                case "open":
                    Open(data, input);
                    break;

                case "mkdir":
                    MakeDirectory(data, input);
                    break;

                case "Is":
                    Traverse(data, input);
                    break;

                case "cmp":
                    CompareFiles(data, input);
                    break;

                case "cdRel":
                    ChangeRelativeDirectory(data, input);
                    break;

                case "cdAbs":
                    ChangeAbsoluteDirectory(data, input);
                    break;

                case "readDb":
                    ReadDataBase(data, input);
                    break;

                case "help":
                    Help();
                    break;

                case "show":
                    ShowData(data, input);
                    break;

                case "filter":
                    Filter(data, input);
                    break;

                case "order":
                    Order(data, input);
                    break;

                case "decOrder":
                    DescendingOrder(data, input);
                    break;

                case "download":
                    Download(data, input);
                    break;

                case "downloadAsynch":
                    DownloadAsync(data, input);
                    break;

                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }

        //Writes a message on the console when a command is invalid.
        public static void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.WriteMessageOnAnewLine($"The command '{input}' is invalid.");
        }

        //Opens files.
        public static void Open(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var fileName = data[1];
                Process.Start(SessionData.currentPath + "\\" + fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Makes directory.
        public static void MakeDirectory(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var folderName = data[1];
                IOManager.CreateDirectoryInCurrentFolder(folderName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Traverses directory.
        public static void Traverse(string[] data, string input)
        {
            if (data.Length == 1)
            {
                IOManager.TraverseDirectory(0);
            }
            else if (data.Length == 2)
            {
                var depth = 0;
                var parsed = int.TryParse(data[1], out depth);

                if (parsed)
                {
                    IOManager.TraverseDirectory(depth);
                }
                else
                {
                    OutputWriter.DisplayExceotions(ExceptionMessages.UnableToParseNumber);
                }
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //CompareFiles.
        public static void CompareFiles(string[] data, string input)
        {
            if (data.Length == 3)
            {
                var firstPath = data[1];
                var secondPath = data[2];
                Tester.CompareContent(firstPath, secondPath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Changes relative directory.
        public static void ChangeRelativeDirectory(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var relativePath = data[1];
                IOManager.ChangeCurrentDirectoryRelative(relativePath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Change absolute directory.
        public static void ChangeAbsoluteDirectory(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var absolutePath = data[1];
                IOManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Reads the database.
        public static void ReadDataBase(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var fileName = data[1];
                StudentRepository.InitializedDada(fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //Provides information about the commands.
        public static void Help()
        {
            OutputWriter.WriteMessageOnAnewLine($"{new string('_', 100)}");
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "make directory - mkdir: path "));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "traverse directory - ls: depth "));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "comparing files - cmp: path1 path2"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "change directory - changeDirREl:relative path"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "change directory - changeDir:absolute path"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "read students data base - readDb: path"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "download file - download: path of file (saved in current directory)"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "download file asinchronously - downloadAsynch: path of file (save in the current directory)"));
            OutputWriter.WriteMessageOnAnewLine(string.Format("|{0, -98}|", "get help – help"));
            OutputWriter.WriteMessageOnAnewLine($"{new string('_', 100)}");
            OutputWriter.WriteEmptyLine();
        }

        //Shows data for the required course/username.
        public static void ShowData(string[] data, string input)
        {
            if (data.Length == 2)
            {
                var courseName = data[1];
                StudentRepository.GetAllStudentsScoresFromCourse(courseName);
            }
            else if (data.Length == 3)
            {
                var courseName = data[1];
                var studentName = data[2];
                StudentRepository.GetStudentScoresFromCourse(courseName, studentName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //???
        public static void Filter(string[] data, string input)
        {
            if (data.Length == 2)
            {
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //???
        public static void Order(string[] data, string input)
        {
            if (data.Length == 2)
            {
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //??? 
        public static void DescendingOrder(string[] data, string input)
        {
            if (data.Length == 2)
            {
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //??? 
        public static void Download(string[] data, string input)
        {
            if (data.Length == 2)
            {
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        //??? 
        public static void DownloadAsync(string[] data, string input)
        {
            if (data.Length == 2)
            {
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }
    }
}