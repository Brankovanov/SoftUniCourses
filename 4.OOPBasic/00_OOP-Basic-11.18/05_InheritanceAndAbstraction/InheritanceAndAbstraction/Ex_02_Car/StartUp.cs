using System;

namespace Ex_02_Car
{
    public class StartUp
    {
        static void Main()
        {
            var driver = Console.ReadLine();

            var newCar = new Ferrary(driver);

            Console.Write(newCar.Model + "/");
            newCar.Brakes();
            Console.Write("/");
            newCar.Gas();
            Console.Write("/" + newCar.Driver) ;
        }
    }
}
