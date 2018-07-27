﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_SortByEmailDomain
{
    public class SortByEmailDomain
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var student = Console.ReadLine();
            var studentList = new List<List<string>>();

            while (student != "END")
            {
                var temp = student.Split(' ').ToList();
                studentList.Add(temp);
                student = Console.ReadLine();
            }

            SortStudents(studentList);
        }

        //Sorts the collection of students first by email domain.
        public static void SortStudents(List<List<string>> studentList)
        {
            foreach (var st in studentList.Where(st => st.Last().EndsWith("@gmail.com")))
            {
                Console.WriteLine(string.Join(" ", st[0],st[1]));
            }
        }
    }
}