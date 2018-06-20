using System;
using System.Collections.Generic;

namespace Lab_03_DecimalToBinary
{
    public class decimalToBinary
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the decimal number from the console.
        static void ReceiveInput()
        {
            var decimalNumber = int.Parse(Console.ReadLine());

            ConvertNumber(decimalNumber);
        }

        //Converts the decimal number into binnart.
        static void ConvertNumber(int decimalNumber)
        {
            var binaryNumber = new Stack<int>();
            if (decimalNumber != 0)
            {
                while (decimalNumber > 0)
                {
                    binaryNumber.Push(decimalNumber % 2);
                    decimalNumber = decimalNumber / 2;
                }

                PrintBinary(binaryNumber);
            }
            else
            {
                binaryNumber.Push(0);
                PrintBinary(binaryNumber);
            }
        }

        //Prints the binary number result.
        static void PrintBinary(Stack<int> binaryNumber)
        {
            while (binaryNumber.Count > 0)
            {
                Console.Write(binaryNumber.Pop());
            }
        }
    }
}