using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_17_CourcePlanning
{
    public class CoursePlanning
    {
        public static void Main(string[] args)
        {
            ReceiveCourseShedule();
        }

        //Receives course shedule from the console.
        static void ReceiveCourseShedule()
        {
            var courseShedule = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            var command = Console.ReadLine();

            while (command != "course start")
            {
                ExecuteCommand(command, courseShedule);
                command = Console.ReadLine();
            }

            PrintFinalCourseShedule(courseShedule);
        }

        //Executes the received commands.
        static void ExecuteCommand(string command, List<string> courseShedule)
        {
            var commandType = string.Empty;
            var lessonTitle = string.Empty;
            var lessonTitleOne = string.Empty;
            var lessonTitleTwo = string.Empty;
            var index = 0;
            var temp = command.Split(':').ToArray();

            commandType = temp[0];

            switch (commandType)
            {
                case "Add":
                    lessonTitle = temp[1];
                    Add(lessonTitle, courseShedule);
                    break;

                case "Insert":
                    lessonTitle = temp[1];
                    index = int.Parse(temp[2]);
                    Insert(lessonTitle, index, courseShedule);
                    break;

                case "Remove":
                    lessonTitle = temp[1];
                    Remove(lessonTitle, courseShedule);
                    break;

                case "Swap":
                    lessonTitleOne = temp[1];
                    lessonTitleTwo = temp[2];
                    Swap(lessonTitleOne, lessonTitleTwo, courseShedule);
                    break;

                case "Exercise":
                    lessonTitle = temp[1];
                    Exercise(lessonTitle, courseShedule);
                    break;
            }
        }

        //Adds new lessons to the end of the course.
        static void Add(string lesonTitle, List<string> courseShedule)
        {
            if (!courseShedule.Contains(lesonTitle))
            {
                courseShedule.Add(lesonTitle);
            }
        }

        //Inserts new lessons at certain position in the course.
        static void Insert(string lesonTitle, int index, List<string> courseShedule)
        {
            if (index >= 0 && index < courseShedule.Count && !courseShedule.Contains(lesonTitle))
            {
                courseShedule.Insert(index, lesonTitle);
            }
        }

        //Remove the given leson and or exercise if they exist.
        static void Remove(string lesonTitle, List<string> courseShedule)
        {
            if (courseShedule.Contains(lesonTitle))
            {
                courseShedule.Remove(lesonTitle);
            }

            if (courseShedule.Contains(lesonTitle + "-Exercise"))
            {
                courseShedule.Remove(lesonTitle + "-Exercise");
            }
        }

        //Swap the position of two courses and their exercises if the exist
        static void Swap(string lesonTitleOne, string lesonTitleTwo, List<string> courseShedule)
        {
            var indexOne = 0;
            var indexTwo = 0;

            if (courseShedule.Contains(lesonTitleOne) && courseShedule.Contains(lesonTitleTwo))
            {
                indexOne = courseShedule.IndexOf(lesonTitleOne);
                indexTwo = courseShedule.IndexOf(lesonTitleTwo);
                courseShedule[indexOne] = lesonTitleTwo;
                courseShedule[indexTwo] = lesonTitleOne;
            }

            if (courseShedule.Contains(lesonTitleOne + "-Exercise"))
            {
                courseShedule.Insert(indexTwo + 1, lesonTitleOne + "-Exercise");
                courseShedule.RemoveAt(courseShedule.LastIndexOf(lesonTitleOne + "-Exercise"));
            }

            if (courseShedule.Contains(lesonTitleTwo + "-Exercise"))
            {
                courseShedule.Insert(indexOne + 1, lesonTitleTwo + "-Exercise");
                courseShedule.RemoveAt(courseShedule.LastIndexOf(lesonTitleTwo + "-Exercise"));
            }
        }

        //Adds lessond and exercises.
        static void Exercise(string lesonTitle, List<string> courseShedule)
        {
            var index = 0;

            if (!courseShedule.Contains(lesonTitle))
            {
                courseShedule.Add(lesonTitle);
                courseShedule.Add(lesonTitle + "-Exercise");
            }

            index = courseShedule.IndexOf(lesonTitle);

            if (courseShedule.Contains(lesonTitle) && !courseShedule.Contains(lesonTitle + "-Exercise") && index < courseShedule.Count)
            {
                courseShedule.Insert(index + 1, lesonTitle + "-Exercise");
            }
            else if (courseShedule.Contains(lesonTitle) && !courseShedule.Contains(lesonTitle + "-Exercise") && index == courseShedule.Count - 1)
            {
                courseShedule.Add(lesonTitle + "-Exercise");
            }
        }

        //Prints the final course shedule on the console.
        static void PrintFinalCourseShedule(List<string> courseShedule)
        {
            for (var index = 1; index <= courseShedule.Count; index++)
            {
                Console.WriteLine(index + "." + courseShedule[index - 1]);
            }
        }
    }
}