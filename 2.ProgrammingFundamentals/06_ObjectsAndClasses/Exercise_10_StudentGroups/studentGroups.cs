using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise_10_StudentGroups
{
    public class studentGroups
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входна информация от конзолата.
        static void ReceiveInput()
        {
            List<string> listOfInput = new List<string>();
            var input = Console.ReadLine();
            listOfInput.Add(input);

            while (input != "End")
            {
                input = Console.ReadLine();
                listOfInput.Add(input);
            }

            listOfInput.Remove("End");
            SortInput(listOfInput);
        }

        //Сортира входните данни и извиква съответните методи.
        static void SortInput(List<string> listOfInputs)
        {
            List<Town> listOfTowns = new List<Town>();

            foreach (var input in listOfInputs)
            {
                if (input.Contains("=>"))
                {
                    CreateTown(input, listOfTowns);
                }
                else
                {
                    JoinCources(input, listOfTowns);
                }
            }

            PrintGroups(listOfTowns);
        }

        //Създава нов град.
        static void CreateTown(string input, List<Town> listOfTown)
        {
            List<string> tempList = new List<string>();
            var seatsAvailable = string.Empty;
            var cityName = string.Empty;

            tempList = input.Split('=').ToList();
            cityName = tempList[0];
            seatsAvailable = tempList[1].Remove(0, 2);
            seatsAvailable = seatsAvailable.Remove(1, 6);

            Town newTown = new Town();
            newTown.TownName = cityName;
            newTown.NumberOfSeats = int.Parse(seatsAvailable);
            newTown.Participants = new List<Student>();

            listOfTown.Add(newTown);
            tempList.Clear();
            cityName = string.Empty;
            seatsAvailable = string.Empty;
        }

        //Прибавя newStudents към списъка студенти на съответния град.
        static void JoinCources(string input, List<Town> listOfTown)
        {
            CultureInfo euCultureInfo = new CultureInfo("bg-Bg");
            List<string> temp = new List<string>();
            var studentName = string.Empty;
            var email = string.Empty;
            DateTime inclusionDate = new DateTime();

            try
            {
                temp = input.Split('|').ToList();
                studentName = temp[0].Trim();
                email = temp[1].Trim();
                inclusionDate = DateTime.Parse(temp[2].Trim(), euCultureInfo);

                Student newStudent = new Student();
                newStudent.Name = studentName;
                newStudent.Email = email;
                newStudent.Date = inclusionDate;

                listOfTown[listOfTown.Count - 1].Participants.Add(newStudent);
                temp.Clear();
                studentName = string.Empty;
                email = string.Empty;
                inclusionDate = new DateTime();
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            temp.Clear();
            studentName = string.Empty;
            email = string.Empty;
            inclusionDate = new DateTime();
        }

        //Принтира отделните групи студенти в различните градове.
        static void PrintGroups(List<Town> listOfTowns)
        {
            var totalCources = 0.0;
            var course = string.Empty;
            List<Student> temporaryStudent = new List<Student>();

            foreach (var place in listOfTowns)
            {
                if (place.NumberOfSeats > 0)
                {
                    totalCources += Math.Ceiling(place.CalculateGroups());
                }
            }

            Console.WriteLine($"Created {totalCources} groups in {listOfTowns.Count} towns:");

            foreach (var town in listOfTowns.OrderBy(x => x.TownName))
            {
                temporaryStudent = town.Participants.OrderBy(x => x.Date).ThenBy(z => z.Name).ThenBy(u => u.Email).ToList();

                if (town.NumberOfSeats > 0)
                {
                    for (var clas = 1; clas <= Math.Ceiling(town.CalculateGroups()); clas++)
                    {
                        course = town.TownName + "=> ";

                        try
                        {
                            for (var part = 0; part <= town.NumberOfSeats - 1; part++)
                            {
                                course += temporaryStudent[part].Email + ", ";
                            }

                            course = course.Remove(course.Count() - 2, 2).ToString();
                            Console.WriteLine(course);
                            temporaryStudent.RemoveRange(0, int.Parse(town.NumberOfSeats.ToString()));
                            course = string.Empty;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            course = course.Remove(course.Count() - 2, 2).ToString();
                            Console.WriteLine(course);
                            temporaryStudent.RemoveRange(0, temporaryStudent.Count);
                            course = string.Empty;
                        }
                    }
                }

                temporaryStudent.Clear();
            }
        }
    }

    //Създава обек newStudent, който се съхранява в списъка студенти на обектите newTown.
    public class Student
    {
        private string name;
        private string email;
        private DateTime date;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public Student()
        {
            this.name = Name;
            this.email = Email;
            this.date = Date;
        }
    }

    //Създава обект newTown, който има име,
    //брой места и списък със студенти, който съдържа обекти newStudent.
    public class Town
    {
        private string townName;
        private double numberOfSeats;
        private List<Student> participants;

        public string TownName
        {
            get
            {
                return this.townName;
            }
            set
            {
                this.townName = value;
            }
        }

        public double NumberOfSeats
        {
            get
            {
                return this.numberOfSeats;
            }
            set
            {
                this.numberOfSeats = value;
            }
        }

        public List<Student> Participants
        {
            get
            {
                return this.participants;
            }
            set
            {
                this.participants = value;
            }
        }

        public Town()
        {
            this.townName = TownName;
            this.numberOfSeats = NumberOfSeats;
            this.participants = Participants;
        }

        //Изчислява, колко курса трябва да се 
        //направят в един град, за да се поберат всички студенти.
        public double CalculateGroups()
        {
            var courses = 0.0;
            courses = participants.Count / NumberOfSeats;
            return courses;
        }
    }
}