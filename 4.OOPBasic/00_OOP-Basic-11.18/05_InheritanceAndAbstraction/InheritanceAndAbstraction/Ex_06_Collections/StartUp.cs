using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_06_Collections
{
    public class StartUp
    {
        public static void Main()
        {
            var newAddCol = new AddCollection();
            var newRemCol = new AddRemoveCollection();
            var newList = new MyList();

            ReceiveInput(newAddCol, newRemCol, newList);
            Print(newAddCol, newRemCol, newList);
        }

        public static void ReceiveInput(AddCollection newAddCol, AddRemoveCollection newRemCol, MyList newList)
        {
            var inputToAdd = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach(var item in inputToAdd)
            {
                AddToCollection(newAddCol, newRemCol, newList, item);
            }

            var removeOperations = int.Parse(Console.ReadLine());

            for(var operation=0;operation<removeOperations;operation++)
            {
                RemoveFromCollection( newRemCol, newList);
            }
        }

        public static void RemoveFromCollection(AddRemoveCollection newRemCol, MyList newList)
        {
            newRemCol.Remove();
            newList.Remove();
        }
        public static void AddToCollection(AddCollection newAddCol, AddRemoveCollection newRemCol, MyList newList,string item)
        {
            newAddCol.Add(item);
            newRemCol.Add(item);
            newList.Add(item);
        }

        public static void Print(AddCollection newAddCol, AddRemoveCollection newRemCol, MyList newList)
        {
            Console.WriteLine(newAddCol.InputResult);
            Console.WriteLine(newRemCol.InputResult);
            Console.WriteLine(newList.InputResult);
            Console.WriteLine(newRemCol.OutputResult);
            Console.WriteLine(newList.OutputResult);
        }
    }
}

