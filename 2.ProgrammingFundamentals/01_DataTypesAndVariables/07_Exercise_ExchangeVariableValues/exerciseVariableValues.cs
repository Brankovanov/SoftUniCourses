using System;

namespace _07_Exercise_ExchangeVariableValues
{
    public class exerciseVariableValues
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var tempA = 0;
            var tempB = 0;

            tempA = a;
            tempB = b;
            a = b;
            b = tempA;

            Console.Write("Before:" + "\n"
                + "a = " + tempA + "\n" 
                + "b = " + tempB + "\n" 
                + "After:" + "\n" 
                + "a = " + a + "\n" 
                + "b = " + b);
        }
    }
}
