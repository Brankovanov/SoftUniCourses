using System;

namespace Exercise_04_BorderControl_
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveTraffic();
        }

        //Receives traffic from the console.
        public static void ReceiveTraffic()
        {
            var traffic = Console.ReadLine();
            var border = new BorderControl();

            while (traffic != "End")
            {
                border.addTraffic(traffic);
                traffic = Console.ReadLine();
            }

            CheckId(border);
        }

        //Checks the id's of the entities in the traffic.
        public static void CheckId(BorderControl border)
        {
            var fake = Console.ReadLine();
            Console.WriteLine(border.CheckId(fake));
        }
    }
}