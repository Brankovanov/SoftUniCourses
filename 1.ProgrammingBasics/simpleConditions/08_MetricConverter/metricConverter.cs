using System;

namespace _08_MetricConverter
{
    public class metricConverter
    {
        public static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            switch (inputMetric)
            {
                case "m":
                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "mm":

                    lenght = lenght / 1000;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "cm":

                    lenght = lenght / 100;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "mi":

                    lenght = lenght / 0.000621371192;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "in":

                    lenght = lenght / 39.3700787;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "km":

                    lenght = lenght / 0.001;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "ft":

                    lenght = lenght / 3.2808399;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;

                case "yd":

                    lenght = lenght / 1.0936133;

                    switch (outputMetric)
                    {
                        case "m":
                            Console.WriteLine(lenght + " m");
                            break;
                        case "mm":
                            Console.WriteLine(lenght * 1000 + " mm");
                            break;
                        case "cm":
                            Console.WriteLine(lenght * 100 + " cm");
                            break;
                        case "mi":
                            Console.WriteLine(lenght * 0.000621371192 + " mi");
                            break;
                        case "in":
                            Console.WriteLine(lenght * 39.3700787 + " in");
                            break;
                        case "km":
                            Console.WriteLine(lenght * 0.001 + " km");
                            break;
                        case "ft":
                            Console.WriteLine(lenght * 3.2808399 + " ft");
                            break;
                        case "yd":
                            Console.WriteLine(lenght * 1.0936133 + " yd");
                            break;
                    }
                    break;
            }
        }
    }
}
