using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04_SortByName
{
    public class SortByName
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives names from the console.
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

        //Sorts the collection of students first by ascending last name and then by descending order by firs order.
        public static void SortStudents(List<List<string>> studentList)
        {
            foreach (var st in studentList.OrderBy(st => st.Last()).ThenByDescending(s => s.First()))
            {
                Console.WriteLine(string.Join(" ", st));
            }
        }
    }
}