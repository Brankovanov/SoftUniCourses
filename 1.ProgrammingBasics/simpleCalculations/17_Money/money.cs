using System;

namespace _17_Money
{
    public class money
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var china = double.Parse(Console.ReadLine());
            var changeTax = double.Parse(Console.ReadLine());

            Calculate(bitcoin, china, changeTax);
        }

        //Calculates the euro that we will receice.
        static void Calculate(int bitcoin, double china, double chageTax)
        {
            var lev = (double)(bitcoin * 1168);
            var dolar = china * 0.15;
            lev += (dolar * 1.76);
            var euro = lev / 1.95;
            euro -= (euro * (chageTax / 100));

            Print(euro);
        }

        //Prints the euro.
        static void Print(double euro)
        {
            Console.WriteLine(String.Format("{0:0.00}", euro));
        }
    }
}