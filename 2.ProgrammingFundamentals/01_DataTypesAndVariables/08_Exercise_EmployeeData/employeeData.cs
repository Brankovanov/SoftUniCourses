using System;

namespace _08_Exercise_EmployeeData
{
    public class employeeData
    {
        public static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var personalId = long.Parse(Console.ReadLine());
            var uniqueId = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + personalId);
            Console.WriteLine("Unique Employee number: " + uniqueId);
        }
    }
}
