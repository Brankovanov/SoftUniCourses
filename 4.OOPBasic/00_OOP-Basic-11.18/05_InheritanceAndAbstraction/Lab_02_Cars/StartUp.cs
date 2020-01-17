﻿using System;

namespace Lab_02_Cars
{
    public class StartUp
    {
        public static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            seat.Start();
            seat.Stop();
            tesla.Start();
            tesla.Stop();       
        }
    }
}
