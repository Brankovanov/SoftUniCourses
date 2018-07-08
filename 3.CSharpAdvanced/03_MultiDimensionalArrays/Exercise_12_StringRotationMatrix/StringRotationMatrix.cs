using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_12_StringRotationMatrix
{
    public class StringRotationMatrix
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var degrees = 0;
            var lenght = 0;
            var stringHolder = new Queue<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                if (input.Contains("Rotate"))
                {
                    var temp = input.Split('(');
                    degrees = int.Parse(temp[1].TrimEnd(')'));
                }
                else
                {
                    stringHolder.Enqueue(input);

                    if (input.Length > lenght)
                    {
                        lenght = input.Length;
                    }
                }

                input = Console.ReadLine();
            }

            CalculateTurningPosition(stringHolder, degrees, lenght);
        }

        //Calculate the required position.
        static void CalculateTurningPosition(Queue<string> stringHolder, int degrees, int lenght)
        {
            var numberOfTurns = degrees / 90;
            var position = 0;

            if (numberOfTurns > 4)
            {
                position = numberOfTurns % 4;
            }
            else
            {
                position = numberOfTurns;
            }

            switch (position)
            {
                case 0:
                    ZeroDegrees(stringHolder);
                    break;
                case 1:
                    NinetyDegrees(stringHolder, lenght);
                    break;
                case 2:
                    HundredAndEighty(stringHolder, lenght);
                    break;
                case 3:
                    TwoHundredAndSeventy(stringHolder, lenght);
                    break;
                case 4:
                    ThreeHundredAndSixty(stringHolder, lenght);
                    break;
            }
        }

        //Rotates the strings 0 degrees
        static void ZeroDegrees(Queue<string> stringHolder)
        {
            while (stringHolder.Count > 0)
            {
                Console.WriteLine(stringHolder.Dequeue());
            }
        }

        //Rotates the string 90 degrees.
        static void NinetyDegrees(Queue<string> stringHolder, int lenght)
        {
            var index = 0;
            var rotatedMatrix = new char[lenght][];
            var temp = stringHolder.ToArray();

            while (index < lenght)
            {
                rotatedMatrix[index] = new char[stringHolder.Count];

                for (var str = 0; str < stringHolder.Count; str++)
                {
                    if (index < temp[str].Length)
                    {
                        rotatedMatrix[index][str] = temp[str][index];
                    }
                    else
                    {
                        rotatedMatrix[index][str] = ' ';
                    }
                }

                index++;
            }

            foreach (var row in rotatedMatrix)
            {
                Console.WriteLine(string.Join(string.Empty, row.Reverse()));
            }
        }

        //Rotates the string 180 degrees.
        static void HundredAndEighty(Queue<string> stringHolder, int lenght)
        {
            var temp = new Stack<string>(stringHolder.ToArray());

            while (temp.Count > 0)
            {
                var differrence = temp.Peek().Length + (lenght - temp.Peek().Length);
                Console.WriteLine(string.Join(string.Empty, temp.Pop().Reverse()).PadLeft(differrence, ' '));
            }
        }

        //Rotates the string 270 degrees.
        static void TwoHundredAndSeventy(Queue<string> stringHolder, int lenght)
        {
            var index = 0;
            var rotatedMatrix = new char[lenght][];
            var temp = stringHolder.ToArray();

            while (index < lenght)
            {
                rotatedMatrix[index] = new char[stringHolder.Count];

                for (var str = 0; str < stringHolder.Count; str++)
                {
                    if (index < temp[str].Length)
                    {
                        rotatedMatrix[index][str] = temp[str][index];
                    }
                    else
                    {
                        rotatedMatrix[index][str] = ' ';
                    }
                }

                index++;
            }

            for (var row = rotatedMatrix.Length - 1; row >= 0; row--)
            {

                Console.WriteLine(string.Join(string.Empty, rotatedMatrix[row]));
            }
        }

        //Rotates the string 360 degrees.
        static void ThreeHundredAndSixty(Queue<string> stringHolder, int lenght)
        {
            ZeroDegrees(stringHolder);
        }
    }
}