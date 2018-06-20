using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04_QueueBasicOperation
{
    public class queueBasicOperations
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var parameters = Console.ReadLine();
            var elements = Console.ReadLine();

            ProcessCommands(parameters, elements);
        }

        //Process the received commands.
        static void ProcessCommands(string parameters, string elements)
        {
            var temp = parameters.Split(' ');
            var elementsToEnqueue = int.Parse(temp[0]);
            var elemetsToDequeue = int.Parse(temp[1]);
            var elementToLookFor = int.Parse(temp[2]);

            ExecuteCommands(elements, elementsToEnqueue, elemetsToDequeue, elementToLookFor);
        }

        //Executes the received commands.
        static void ExecuteCommands(string elements, int elementsToEnqueue, int elementsToDequeue, int elementToLookFor)
        {
            var queue = new Queue<int>(Enqueue(elements, elementsToEnqueue).ToArray());
            Dequeue(queue, elementsToDequeue);
            FindElement(queue, elementToLookFor);
        }

        //Add elements to the queue.
        static List<int> Enqueue(string elements, int elementsToEnqueue)
        {
            var tempElements = elements.Split(' ').Select(e => int.Parse(e)).ToList();
            tempElements.RemoveRange(elementsToEnqueue, tempElements.Count - elementsToEnqueue);
            return tempElements;
        }

        //Remove elements from the queue.
        static void Dequeue(Queue<int> queue, int elementsToDequeue)
        {
            for (var outIndex = 1; outIndex <= elementsToDequeue; outIndex++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }
        }

        //Finds specified element in the queue.
        static void FindElement(Queue<int> queue, int elementToLookFor)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}