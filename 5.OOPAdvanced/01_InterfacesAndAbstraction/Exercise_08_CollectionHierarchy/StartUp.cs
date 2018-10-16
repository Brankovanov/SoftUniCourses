using System;

namespace Exercise_08_CollectionHierarchy
{
    public class StartUp
    {
        static void Main()
        {
            CreateCollections();
        }

        //Creates collections.
        public static void CreateCollections()
        {
            var addColl = new AddCollection();
            var addRemoveColl = new AddRemoveCollection();
            var myList = new MyList();

            ReceiveInput(addColl, addRemoveColl, myList);
        }

        //Receives input commands from the console.
        public static void ReceiveInput(IAddCollection addColl, IAddRemoveCollection addRemoveColl, MyList myList)
        {
            var elementsToAdd = Console.ReadLine().Split(' ');
            var numberToRemove = int.Parse(Console.ReadLine());

            PrintResults(addColl, addRemoveColl, myList, elementsToAdd, numberToRemove);
        }

        //Adds and removes the required elements.
        public static string ManipulateCollections(IAddCollection addColl, IAddRemoveCollection addRemoveColl, MyList myList, string[] elementsToAdd, int numberToremove)
        {
            var output = string.Empty;

            foreach (var item in elementsToAdd)
            {
                output += addColl.Add(item).ToString() + " ";
            }

            output += Environment.NewLine;

            foreach (var item in elementsToAdd)
            {
                output += addRemoveColl.Add(item).ToString() + " ";
            }

            output += Environment.NewLine;

            foreach (var item in elementsToAdd)
            {
                output += myList.Add(item).ToString() + " ";
            }

            output += Environment.NewLine;

            for (var ind = 0; ind < numberToremove; ind++)
            {
                output += addRemoveColl.Remove() + " ";
            }

            output += Environment.NewLine;

            for (var ind = 0; ind < numberToremove; ind++)
            {
                output += myList.Remove() + " ";
            }

            return output;
        }

        //Prints the results from the collection manipulations.\
        public static void PrintResults(IAddCollection addColl, IAddRemoveCollection addRemoveColl, MyList myList, string[] elementsToAdd, int numberToremove)
        {
            Console.WriteLine(ManipulateCollections(addColl, addRemoveColl, myList, elementsToAdd, numberToremove));
        }
    }
}