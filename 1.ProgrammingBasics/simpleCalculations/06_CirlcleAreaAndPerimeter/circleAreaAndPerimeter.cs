﻿using System;

namespace _06_CirlcleAreaAndPerimeter
{
    public class circleAreaAndPerimeter
    {
        public static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = { perimeter}");
        }
    }
}
