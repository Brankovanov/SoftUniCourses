using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_11_KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var gunBarrel = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var bulletStack = new Stack<int>(bullets);
            var locks = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var lockQueue = new Queue<int>(locks);
            var payment = int.Parse(Console.ReadLine());

            Shooting(bulletPrice, gunBarrel, bulletStack, lockQueue, payment);
        }

        private static void Shooting(int bulletPrice, int gunBarrel, Stack<int> bulletStack, Queue<int> lockQueue, int payment)
        {
            var shots = 0;
            var moneySpend = 0;

            while (true)
            {
                if (bulletStack.Count == 0 && lockQueue.Count != 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {lockQueue.Count}");
                    break;
                }
                else
                {

                    if (shots < gunBarrel)
                    {
                        if (lockQueue.Count == 0)
                        {
                            Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${payment - moneySpend}");
                            break;
                        }
                        else
                        {
                            shots++;
                            moneySpend += bulletPrice;

                            if (bulletStack.Peek() <= lockQueue.Peek())
                            {
                                Console.WriteLine("Bang!");
                                bulletStack.Pop();
                                lockQueue.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("Ping!");
                                bulletStack.Pop();
                            }
                        }
                    }
                    else
                    {
                        if (bulletStack.Count > 0)
                        {
                            Console.WriteLine("Reloading!");                           
                        }
                        shots = 0;
                    }
                }
            }
        }
    }
}
