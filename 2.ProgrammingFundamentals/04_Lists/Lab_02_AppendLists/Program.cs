using System;
using System.Collections.Generic;
using System.Linq;

namespace Lap_02_AppendList
{
    public class appendList
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CreateList(input);
        }

        static void CreateList(string input)
        {
            List<string> newList = input.Split('|').Reverse().ToList();
            List<string> temList = new List<string>();
            foreach (var list in newList)
            {
                temList.AddRange(list.Split());
                Print(temList);
            }
        }

        static void Print(List<string> tempList)
        {
            tempList.Remove(" ");

            foreach (var ch in tempList)
            {
                Console.Write(ch + " ");
            }

            tempList.RemoveRange(0, tempList.Count);
        }
    }
}
