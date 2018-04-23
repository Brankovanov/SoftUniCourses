using System;

namespace Exercise_02_GetMax
{
    public class getMax
    {
        public static void Main(string[] args)
        {
            var firstNum = 0;
            var secondNum = 0;
            var thirdNum = 0;

            Input(firstNum, secondNum, thirdNum);
        }

        static void Input(int firstNum, int secondNum, int thirdNum)
        {
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());
            thirdNum = int.Parse(Console.ReadLine());

            GetMax(firstNum, secondNum, thirdNum);
        }

        static void GetMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else if (thirdNum >= firstNum && thirdNum >= secondNum)
            {
                Console.WriteLine(thirdNum);
            }
        }
    }
}
