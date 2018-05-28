using System;

namespace Exercise_01_CountWorkingDays
{
    public class countWorkingDay
    {
        public static void Main(string[] args)
        {
            ReceiveDates();
        }

        //Получава стартова и финална дата.
        static void ReceiveDates()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            CreateWorkingDates(firstDate, secondDate);
        }

        //Създава обект, който изчислява работните дати между две дати.
        static void CreateWorkingDates(string firstDate, string secondDate)
        {
            WorkingDates workingDate = new WorkingDates(firstDate, secondDate);
            workingDate.DateOne = firstDate;
            workingDate.DateTwo = secondDate;

            PrintWorkingDate(workingDate);
        }

        //Принтира броя на работните дати.
        static void PrintWorkingDate(WorkingDates workinfDate)
        {
            workinfDate.CalculateWorkintDates();
        }
    }

    //Създава обект, който изчислява работните дни между две дати.
    public class WorkingDates
    {
        private string dateOne;
        private string dateTwo;

        public string DateOne
        {
            get
            {
                return this.dateOne;
            }
            set
            {
                this.dateOne = value;
            }
        }

        public string DateTwo
        {
            get
            {
                return this.dateTwo;
            }
            set
            {
                this.dateTwo = value;
            }
        }

        public WorkingDates(string firstDate, string secondDate)
        {
            this.dateOne = firstDate;
            this.dateTwo = secondDate;
        }

        public void CalculateWorkintDates()
        {
            var tempOne = dateOne.Split('-');
            var tempTwo = dateTwo.Split('-');
            var start = new DateTime(int.Parse(tempOne[2]), int.Parse(tempOne[1]), int.Parse(tempOne[0]));
            var end = new DateTime(int.Parse(tempTwo[2]), int.Parse(tempTwo[1]), int.Parse(tempTwo[0]));
            var workindDays = 0;

            for (var index = start; start <= end; start = start.AddDays(1))
            {
                var tempDay = start.DayOfWeek;

                if (tempDay.ToString().Equals("Saturday") || tempDay.ToString().Equals("Sunday"))
                {
                }
                else
                {
                    if ((start.Day.ToString().Equals("24") && start.Month.ToString().Equals("12"))
                 || (start.Day.ToString().Equals("25") && start.Month.ToString().Equals("12"))
                 || (start.Day.ToString().Equals("26") && start.Month.ToString().Equals("12"))
                 || (start.Day.ToString().Equals("1") && start.Month.ToString().Equals("1"))
                 || (start.Day.ToString().Equals("3") && start.Month.ToString().Equals("3"))
                 || (start.Day.ToString().Equals("1") && start.Month.ToString().Equals("5"))
                 || (start.Day.ToString().Equals("6") && start.Month.ToString().Equals("5"))
                 || (start.Day.ToString().Equals("24") && start.Month.ToString().Equals("5"))
                 || (start.Day.ToString().Equals("22") && start.Month.ToString().Equals("9"))
                 || (start.Day.ToString().Equals("6") && start.Month.ToString().Equals("9"))
                 || (start.Day.ToString().Equals("1") && start.Month.ToString().Equals("11")))
                    {
                    }
                    else
                    {
                        workindDays++;
                    }
                }
            }

            Console.Write(workindDays);
        }
    }
}




