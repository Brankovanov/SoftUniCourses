using System;

namespace _04_ManKind
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var studentInformation = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var studentFirstName = studentInformation[0];
            var studentSecondName = studentInformation[1];
            var facultyNumber = studentInformation[2];

            var workerInformation = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerInformation[0];
            var workerSecondName = workerInformation[1];
            var salary = decimal.Parse(workerInformation[2]);
            var workingHours = int.Parse(workerInformation[3]);

            try
            {
                var newStudent = new Student(studentFirstName, studentSecondName, facultyNumber);
                PrintInformation(newStudent);              
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                var newWorker = new Worker(workerFirstName, workerSecondName, salary, workingHours);
                PrintInformation(newWorker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void PrintInformation(Human human)
        {
            Console.WriteLine(human.ToString());
        }
    }
}