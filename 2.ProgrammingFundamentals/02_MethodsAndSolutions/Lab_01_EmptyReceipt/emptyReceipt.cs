using System;

namespace Lab_01_EmptyReceipt
{
    public class emptyReceipt
    {
        public static void Main(string[] args)
        {
            BlankReceipt();
        }

        static void BlankReceipt()
        {
            Heather();
            Body();
            Footer();
        }

        static void Heather()
        {          
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
