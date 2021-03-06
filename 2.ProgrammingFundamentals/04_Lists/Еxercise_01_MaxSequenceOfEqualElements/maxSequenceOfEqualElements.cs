﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Еxercise_01_MaxSequenceOfEqualElements
{
    public class maxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CreateArray(input);
        }

        static void CreateArray(string input)
        {
            var mainArray = input.Split(' ').Select(x => int.Parse(x)).ToList();

            SortArray(mainArray);
        }

        static void SortArray(List<int> mainArray)
        {
            if (mainArray.Count == 1)
            {
                Console.Write(mainArray[0]);
            }
            else
            {
                var temporaryString = new List<int>();
                var finalString = new List<int>();

                for (var index = 0; index <= mainArray.Count - 2; index++)
                {
                    if (mainArray[index + 1] == mainArray[index])
                    {
                        temporaryString.Add(mainArray[index]);

                        if (index == mainArray.Count - 2)
                        {
                            if (finalString.Count >= temporaryString.Count)
                            {
                                temporaryString.RemoveRange(0, temporaryString.Count);
                            }
                            else if (finalString.Count < temporaryString.Count)
                            {
                                finalString.RemoveRange(0, finalString.Count);
                                finalString.AddRange(temporaryString);
                                temporaryString.RemoveRange(0, temporaryString.Count);
                            }
                        }
                    }
                    else
                    {
                        if (finalString.Count >= temporaryString.Count)
                        {
                            temporaryString.RemoveRange(0, temporaryString.Count);
                        }
                        else if (finalString.Count < temporaryString.Count)
                        {
                            finalString.RemoveRange(0, finalString.Count);
                            finalString.AddRange(temporaryString);
                            temporaryString.RemoveRange(0, temporaryString.Count);
                        }
                    }
                }

                Print(finalString);
            }

        }

        static void Print(List<int> finalString)
        {
            foreach (var ch in finalString)
            {
                Console.Write(ch + " ");
            }

            Console.Write(int.Parse(finalString[finalString.Count - 1].ToString()));
        }
    }
}
