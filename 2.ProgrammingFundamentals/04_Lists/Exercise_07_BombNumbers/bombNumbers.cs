using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_BombNumbers
{
    public class bombNumbers
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var inputNum = Console.ReadLine();
            var bombNum = Console.ReadLine();

            CreateList(inputNum, bombNum);
        }

        static void CreateList(string inputNum, string bombNum)
        {
            List<int> listNumbers = new List<int>();
            List<int> bombList = new List<int>();

            listNumbers = inputNum.Split(' ').Select(x => int.Parse(x)).ToList();
            bombList = bombNum.Split(' ').Select(y => int.Parse(y)).ToList();

            var bomb = bombList[0];
            var powerOfExplosion = bombList[1];

            FindBombs(listNumbers, bomb, powerOfExplosion);
        }

        static void FindBombs(List<int> listNumbers, int bomb, int powerOfExplosion)
        {
            var leftBlastRadius = 0;
            var rightBlastRadius = 0;

            for (var index = 0; index <= listNumbers.Count - 1; index++)
            {
                if (listNumbers[index] == bomb)
                {
                    DetonateBomb(listNumbers, leftBlastRadius, rightBlastRadius, powerOfExplosion, index);
                }
            }

            listNumbers.RemoveAll(x => x == bomb);

            Sum(listNumbers);
        }

        static void DetonateBomb(List<int> listNumbers, int leftBlastRadius, int rightBlastRadius, int powerOfExplosion, int index)
        {
            leftBlastRadius = index - powerOfExplosion;

            if (leftBlastRadius >= 0)
            {
                for (var i = leftBlastRadius; i <= leftBlastRadius + powerOfExplosion; i++)
                {
                    listNumbers[i] = 0;
                }

            }
            else if (leftBlastRadius < 0)
            {
                for (var z = 0; z <= index; z++)
                {
                    listNumbers[z] = 0;
                }
            }

            rightBlastRadius = index + powerOfExplosion;

            if (rightBlastRadius <= listNumbers.Count)
            {
                for (var x = index; x <= index + powerOfExplosion; x++)
                {
                    listNumbers[x] = 0;
                }
            }
            else if (rightBlastRadius > listNumbers.Count)
            {
                for (var y = index; y <= listNumbers.Count; y++)
                {
                    listNumbers[y] = 0;
                }
            }
        }

        static void Sum(List<int> listNumbers)
        {
            var sum = 0;

            foreach (var num in listNumbers)
            {
                sum += num;
            }

            Print(sum);
        }

        static void Print(int sum)
        {
            Console.Write(sum);
        }
    }
}
