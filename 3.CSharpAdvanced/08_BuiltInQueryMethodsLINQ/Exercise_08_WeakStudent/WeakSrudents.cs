﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_WeakStudent
{
    public class WeakSrudents
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var student = Console.ReadLine();
            var studentList = new Dictionary<string, List<int>>();
            var name = string.Empty;
            var grades = new List<int>();

            while (student != "END")
            {
                var temp = student.Split(' ').ToList();
                name = temp[0] + " " + temp[1];
                grades.AddRange(temp.Skip(2).Select(g => int.Parse(g)));

                if (studentList.ContainsKey(name))
                {
                    studentList[name].AddRange(grades);
                }
                else if (!studentList.ContainsKey(name))
                {
                    studentList.Add(name, new List<int>());
                    studentList[name].AddRange(grades);
                }

                grades.Clear();
                student = Console.ReadLine();
            }

            SortStudents(studentList);
        }

        //Sorts the collection of students by their low grades.
        public static void SortStudents(Dictionary<string, List<int>> studentList)
        {
            foreach (var st in studentList)
            {
                if(st.Value.Count(t => t <= 3)>=2)
                {
                    Console.WriteLine(st.Key);
                }               
            }
        }
    }
}