using System;
using System.Collections.Generic;

namespace Lab_02_SimpleCalculator
{
    public class simpleCalculator
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            CreateStack(input);
        }

        //Procces the input. 
        static void CreateStack(string input)
        {
            var temp = input.Split(' ');
            var newCalculus = new Stack<string>();

            foreach (var num in temp)
            {
                newCalculus.Push(num);
            }

            Calculate(newCalculus);
        }

        //Calculates the result.
        static void Calculate(Stack<string> newCalculus)
        {
            var result = 0;
            var member = 0;

            while (newCalculus.Count > 0)
            {
                var tempNum = newCalculus.Pop();
                if (int.TryParse(tempNum, out int number))
                {
                    member = number;

                }
                else if (tempNum.Equals("+"))
                {

                    result += member;
                    member = 0;
                }
                else if (tempNum.Equals("-"))
                {
                    result -= member;
                    member = 0;
                }           
            }

            if (newCalculus.Count == 0 && member != 0)
            {
                result += member;
            }

            Print(result);
        }

        //Prints the result.
        static void Print(int result)
        {
            Console.WriteLine(result);
        }
    }
}