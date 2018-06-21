using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab_03_CompareStructures
{
    public class compareStructures
    {
        public static void Main(string[] args)
        {
            ListOperations();
            DictionaryOperations();
            SortedDictionaryOperations();
            HashSetOperations();
            SortedSetOperations();
            StackOperations();
            QueueOperations();
        }
    
        //Runs List operations.
        static void ListOperations()
        {
            var list = new List<int>();
            var listWatch = Stopwatch.StartNew();

            for(var index=1; index<=1000000; index++)
            {
                list.Add(index);
            }

            listWatch.Stop();
            Console.WriteLine("Structure List - Operation Add(): " + listWatch.ElapsedTicks + " timer ticks.");

            listWatch = Stopwatch.StartNew();

            list.Contains(77777);
           
            listWatch.Stop();
            Console.WriteLine("Structure List - Operation Contains(): " + listWatch.ElapsedTicks + " timer ticks.");

            listWatch = Stopwatch.StartNew();

            list.Remove(77777);

            listWatch.Stop();
            Console.WriteLine("Structure List - Operation Remove(): " + listWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Stack operations.
        static void StackOperations()
        {
            var stack = new Stack<int>();
            var stackWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                stack.Push(index);
            }

            stackWatch.Stop();
            Console.WriteLine("Structure Stack - Operation Push(): " + stackWatch.ElapsedTicks + " timer ticks.");

            stackWatch = Stopwatch.StartNew();

            stack.Contains(77777);

            stackWatch.Stop();
            Console.WriteLine("Structure Stack - Operation Contains(): " + stackWatch.ElapsedTicks + " timer ticks.");

            stackWatch = Stopwatch.StartNew();

            stack.Peek();

            stackWatch.Stop();
            Console.WriteLine("Structure Stack - Operation Peek(): " + stackWatch.ElapsedTicks + " timer ticks.");

            stackWatch = Stopwatch.StartNew();

            stack.Pop();

            stackWatch.Stop();
            Console.WriteLine("Structure Stack - Operation Pop(): " + stackWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Queue operations.
        static void QueueOperations()
        {
            var queue = new Queue<int>();
            var queueWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                queue.Enqueue(index);
            }

            queueWatch.Stop();
            Console.WriteLine("Structure Queue - Operation Enqueue(): " + queueWatch.ElapsedTicks + " timer ticks.");

            queueWatch = Stopwatch.StartNew();

            queue.Contains(77777);

            queueWatch.Stop();
            Console.WriteLine("Structure Queue - Operation Contains(): " + queueWatch.ElapsedTicks + " timer ticks.");

            queueWatch = Stopwatch.StartNew();

            queue.Peek();

            queueWatch.Stop();
            Console.WriteLine("Structure Queue - Operation Peek(): " + queueWatch.ElapsedTicks + " timer ticks.");

            queueWatch = Stopwatch.StartNew();

            queue.Dequeue();

            queueWatch.Stop();
            Console.WriteLine("Structure Queue - Operation Dequeue(): " + queueWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Hash Set operations.
        static void HashSetOperations()
        {
            var hashSet = new HashSet<int>();
            var hashSetWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                hashSet.Add(index);
            }

            hashSetWatch.Stop();
            Console.WriteLine("Structure Hash Set - Operation Add(): " + hashSetWatch.ElapsedTicks + " timer ticks.");

            hashSetWatch = Stopwatch.StartNew();

            hashSet.Contains(77777);

            hashSetWatch.Stop();
            Console.WriteLine("Structure Hash Set - Operation Contains(): " + hashSetWatch.ElapsedTicks + " timer ticks.");
            
            hashSetWatch = Stopwatch.StartNew();

            hashSet.Remove(77777);

            hashSetWatch.Stop();
            Console.WriteLine("Structure Hash Set - Operation Remove(): " + hashSetWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Ordered Set operations.
        static void SortedSetOperations()
        {
            var sortedSet = new SortedSet<int>();
            var sortedSetWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                sortedSet.Add(index);
            }

            sortedSetWatch.Stop();
            Console.WriteLine("Structure Sorted Set - Operation Add(): " + sortedSetWatch.ElapsedTicks + " timer ticks.");

            sortedSetWatch = Stopwatch.StartNew();

            sortedSet.Contains(77777);

            sortedSetWatch.Stop();
            Console.WriteLine("Structure Sorted Set - Operation Contains(): " + sortedSetWatch.ElapsedTicks + " timer ticks.");

            sortedSetWatch = Stopwatch.StartNew();

            sortedSet.Remove(77777);

            sortedSetWatch.Stop();
            Console.WriteLine("Structure Sorted Set - Operation Remove(): " + sortedSetWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Dictionary operations.
        static void DictionaryOperations()
        {
            var dictionary = new Dictionary<int,int>();
            var dictionaryWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                dictionary.Add(index,index);
            }

            dictionaryWatch.Stop();
            Console.WriteLine("Structure Dictionary - Operation Add(): " + dictionaryWatch.ElapsedTicks + " timer ticks.");

            dictionaryWatch = Stopwatch.StartNew();

            dictionary.ContainsKey(77777);

            dictionaryWatch.Stop();
            Console.WriteLine("Structure Dictionary - Operation ContainsKey(): " + dictionaryWatch.ElapsedTicks + " timer ticks.");

            dictionaryWatch = Stopwatch.StartNew();

            dictionary.Remove(77777);

            dictionaryWatch.Stop();
            Console.WriteLine("Structure Dictionary - Operation Remove(): " + dictionaryWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }

        //Runs Sorted Dictionary operations.
        static void SortedDictionaryOperations()
        {
            var sortedDictionary = new SortedDictionary<int, int>();
            var sortedDictionaryWatch = Stopwatch.StartNew();

            for (var index = 1; index <= 1000000; index++)
            {
                sortedDictionary.Add(index, index);
            }

            sortedDictionaryWatch.Stop();
            Console.WriteLine("Structure Sorted Dictionary - Operation Add(): " + sortedDictionaryWatch.ElapsedTicks + " timer ticks.");

            sortedDictionaryWatch = Stopwatch.StartNew();

            sortedDictionary.ContainsKey(77777);

            sortedDictionaryWatch.Stop();
            Console.WriteLine("Structure Sorted Dictionary - Operation ContainsKey(): " + sortedDictionaryWatch.ElapsedTicks + " timer ticks.");

            sortedDictionaryWatch = Stopwatch.StartNew();

            sortedDictionary.Remove(77777);

            sortedDictionaryWatch.Stop();
            Console.WriteLine("Structure Sorted Dictionary - Operation Remove(): " + sortedDictionaryWatch.ElapsedTicks + " timer ticks.");

            Console.WriteLine();
        }
    }
}