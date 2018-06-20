using System;
using System.Collections.Generic;

namespace Lab_06_TrafficJam
{
    public class trafficJam
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var trafficJam = new Queue<string>();
            var numberOfPassedCars = 0;

            var numberOfCars = int.Parse(Console.ReadLine());
            var traffic = Console.ReadLine();

            while (traffic != "end")
            {
                if (traffic.Equals("green"))
                {
                    for (var car = 1; car <= numberOfCars; car++)
                    {
                        try
                        {
                            var passedCar = trafficJam.Dequeue();
                            PrintPassedCars(passedCar);
                            numberOfPassedCars++;
                        }
                        catch (InvalidOperationException)
                        {
                        }
                    }
                }
                else
                {
                    trafficJam.Enqueue(traffic);
                }

                traffic = Console.ReadLine();
            }

            PrintFinalNumberOfPassedCars(numberOfPassedCars);
        }

        //Prints the cars that pass the trafic light on a green light.
        static void PrintPassedCars(string passedCar)
        {
            Console.WriteLine(passedCar + " passed!");
        }

        //Prints how many cars managed to pass.
        static void PrintFinalNumberOfPassedCars(int numberOfPassedCars)
        {
            Console.WriteLine(numberOfPassedCars + " cars passed the crossroads.");
        }
    }
}