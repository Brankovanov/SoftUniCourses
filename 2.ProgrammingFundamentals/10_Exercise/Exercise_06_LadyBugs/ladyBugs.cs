using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_LadyBugs
{
    public class ladyBugs
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var bugPositions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            var field = new List<bool>();
            field.AddRange(CreateField(fieldSize, bugPositions));

            var commads = Console.ReadLine();

            while (commads != "end")
            {
                MoveBugs(commads, field);
                commads = Console.ReadLine();
            }

            Print(field);
        }

        //Create action field.
        static bool[] CreateField(int fieldSize, List<int> bugPositions)
        {
            var temp = new bool[fieldSize];

            foreach (var position in bugPositions)
            {
                if (position >= 0 && position <= temp.Length - 1)
                {
                    temp[position] = true;
                }
            }

            return temp;
        }

        //If possible move the bugs on the fields according the commands.
        static void MoveBugs(string commands, List<bool> field)
        {
            var temp = commands.Split(' ');
            var startingField = int.Parse(temp[0]);
            var command = temp[1];
            var distance = int.Parse(temp[2]);

            try
            {
                if (field[startingField] == false)
                {
                    return;
                }
                else if (field[startingField] == true && command == "right")
                {
                    MoveRight(field, startingField, distance);
                }
                else if (field[startingField] == true && command == "left")
                {
                    MoveLeft(field, startingField, distance);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        //Move the bug right.
        static void MoveRight(List<bool> field, int startingField, int distance)
        {
            field[startingField] = false;

            try
            {
                while (field[startingField + distance] == true)
                {
                    startingField += distance;
                }

                field[startingField + distance] = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
    
        //Move the bug left.
        static void MoveLeft(List<bool> field, int startingField, int distance)
        {
            field[startingField] = false;

            try
            {
                while (field[startingField - distance] == true)
                {
                    startingField -= distance;
                }

                field[startingField - distance] = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        //Print the bugs after the end of the game.
        static void Print(List<bool> field)
        {
            foreach (var position in field)
            {
                if (position == true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
        }
    }
}