using System;

namespace Exercise_05_Birthday
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveTraffic();
        }

        //Receives entities from the console.
        public static void ReceiveTraffic()
        {
            var traffic = Console.ReadLine();
            var birth = new BirthdayControl();

            while (traffic != "End")
            {
                birth.addEntities(traffic);
                traffic = Console.ReadLine();
            }

            CheckId(birth);
        }

        //Checks the birthyears's of the entities in the traffic.
        public static void CheckId(BirthdayControl birth)
        {
            var birthYear = Console.ReadLine();
            Console.WriteLine(birth.CheckBirthay(birthYear));
        }
    }
}