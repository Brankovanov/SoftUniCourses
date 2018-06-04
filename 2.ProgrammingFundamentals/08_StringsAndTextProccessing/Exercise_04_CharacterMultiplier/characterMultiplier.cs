using System;

namespace Exercise_04_CharacterMultiplier
{
    public class characterMultiplier
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема вход от конзолата.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ');
            var stringOne = input[0];
            var stringTwo = input[1];

            MultiplyCharacters(stringOne, stringTwo);
        }

        //Умножава стойността на кодовете на отделните символи.
        static void MultiplyCharacters(string stringOne, string stringTwo)
        {
            var sum = 0;

            if (stringOne.Length >= stringTwo.Length)
            {
                for (var index = 0; index <= stringTwo.Length - 1; index++)
                {
                    sum += ((int)stringOne[index]) * ((int)stringTwo[index]);
                }

                for (var leftover = stringTwo.Length; leftover <= stringOne.Length - 1; leftover++)
                {
                    sum += ((int)stringOne[leftover]);
                }              
            }
            else
            {
                for (var index = 0; index <= stringOne.Length - 1; index++)
                {
                    sum += ((int)stringOne[index]) * ((int)stringTwo[index]);
                }

                for (var leftover = stringOne.Length; leftover <= stringTwo.Length - 1; leftover++)
                {
                    sum += ((int)stringTwo[leftover]);
                }
            }

            PrintOutPut(sum);
        }

        //Отпечатва отговора на конзолата.
        static void PrintOutPut(int sum)
        {
            Console.WriteLine(sum);
        }
    }
}
