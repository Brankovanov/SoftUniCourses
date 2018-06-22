using System;

namespace _19_DailySalary
{
    public class dailySalary
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var workingDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var exchangeCourse = double.Parse(Console.ReadLine());

            CalculateSalary(workingDays, moneyPerDay, exchangeCourse);
        }

        //Calculates the received money.
        static void CalculateSalary(int workingDays, double moneyPerDay, double exchangeCourse)
        {
            var monthSalary = moneyPerDay * workingDays;
            var yearSalary = monthSalary * 12;
            var yearBonus = monthSalary * 2.5;
            yearSalary += yearBonus;
            var taxes = yearSalary * 0.25;
            yearSalary -= taxes;
            var daySalary = yearSalary / 365;
            daySalary = daySalary * exchangeCourse;

            Print(daySalary);
        }

        //Prints day salary.
        static void Print(double daySalary)
        {
            Console.Write(String.Format("{0:0.00}", daySalary));
        }
    }
}