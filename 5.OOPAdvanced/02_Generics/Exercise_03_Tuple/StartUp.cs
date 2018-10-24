using System;
using System.Linq;

namespace Exercise_03_Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tupleList = new Tuple<string>();

            ReceiveInput(tupleList);
            PrintTuples(tupleList);
        }

        //Receives input frpm the console.
        public static void ReceiveInput(Tuple<string>tupleList)
        {
            var input = string.Empty;

            for(var index = 0; index<3;index++)
            {
                input = Console.ReadLine();
                var temp = input.Split(' ').ToArray();

                if(temp.Length==4)
                {
                    var itemOne = temp[0]+" "+temp[1];
                    var itemTwo = temp[2];
                    var itemTree = temp[3];
                    
                    tupleList.CreateTreeuple(itemOne,itemTwo,itemTree);
                }
                else if (temp.Length==3)
                {
                    var itemOne = temp[0];
                    var itemTwo = temp[1];
                    var itemTree = temp[2];

                    if(itemTree.ToLower().Equals("drunk"))
                    {
                        itemTree = "True";
                    }
                    else if(itemTree.ToLower().EndsWith("drunk") || itemTree.ToLower().Contains("not"))
                    {
                        itemTree = "False";
                    }

                    if (double.TryParse(itemTwo, out double num))
                    {
                        itemTwo = itemTwo.TrimEnd('0');
                    }

                    tupleList.CreateTreeuple(itemOne, itemTwo, itemTree);
                }
                else
                {
                    var itemOne = temp[0];
                    var itemTwo = temp[1];

                    tupleList.CreateTuple(itemOne,itemTwo);
                }
            }
        }

        //Prints the created tupples.
        public static void PrintTuples(Tuple<string>  tupleList)
        {
            if(tupleList.TupleList.Count>0)
            {
                foreach (var t in tupleList.TupleList)
                {
                    Console.WriteLine(t.Item1 + " -> " + t.Item2);
                }
            }

            if (tupleList.TreeupleList.Count > 0)
            {
                foreach (var t in tupleList.TreeupleList)
                {
                    Console.WriteLine(t.Item1 + " -> " + t.Item2 + " -> " + t.Item3);
                }
            }
        }
    }
}