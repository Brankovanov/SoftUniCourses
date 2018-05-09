using System;

namespace Exercise_06_MaxSequenceEqualElements
{
    public class maxSequenceEqualElements
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
            var sequenceArray = input.Split(' ');

            CompareSequence(sequenceArray);
        }

        static void CompareSequence(string[] sequenceArray)
        {
            var finalSequence = string.Empty;
            var firstSequence = string.Empty;
            var counter = sequenceArray.Length - 2;

            for (var index = 0; index <= counter; index++)
            {
                if (sequenceArray[index].Equals(sequenceArray[index + 1]))
                {
                    firstSequence += sequenceArray[index].ToString();

                    if (firstSequence.Length > finalSequence.Length)
                    {
                        finalSequence = firstSequence;

                        if (index == counter)
                        {
                            if (finalSequence.Length > 0)
                            {
                                Print(finalSequence + finalSequence[0].ToString());
                            }
                            else
                            {
                                Console.Write(sequenceArray[0]);
                            }
                        }
                    }
                    else if (firstSequence.Length <= finalSequence.Length)
                    {
                        if (index == counter)
                        {
                            if (finalSequence.Length > 0)
                            {
                                Print(finalSequence + finalSequence[0].ToString());
                            }
                            else
                            {
                                Console.Write(sequenceArray[0]);
                            }
                        }
                    }
                }
                else
                {
                    firstSequence = string.Empty;

                    if (firstSequence.Length > finalSequence.Length)
                    {
                        finalSequence = firstSequence;

                        if (index == counter)
                        {
                            if(finalSequence.Length>0)
                            {
                                Print(finalSequence + finalSequence[0].ToString());
                            }
                            else
                            {
                                Console.Write(sequenceArray[0]);
                            }                           
                        }
                    }
                    else if (firstSequence.Length <= finalSequence.Length)
                    {
                        if (index == counter)
                        {
                            if (finalSequence.Length > 0)
                            {
                                Print(finalSequence + finalSequence[0].ToString());
                            }
                            else
                            {
                                Console.Write(sequenceArray[0]);
                            }
                        }
                    }
                }
            }
        }

        static void Print(string finalSequence)
        {           
            foreach (var ch in finalSequence)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
