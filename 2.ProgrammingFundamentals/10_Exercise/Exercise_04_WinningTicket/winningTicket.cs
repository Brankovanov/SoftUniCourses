using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_04_WinningTicket
{
    public class winningTicket
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            ProccessTickets(tickets);
        }

        //Обработва получените билети.
        static void ProccessTickets(List<string> tickets)
        {
            var firstHalf = string.Empty;
            var secondHalf = string.Empty;
            var output = string.Empty;
            var winningPattern = @"(#{1,10})|(\^{1,10})|(@{1,10})|(\${1,10})";

            foreach (var ticket in tickets)
            {
                if (ticket.Length < 20 || ticket.Length > 20)
                {
                    output = "invalid ticket";
                    Print(output);
                }
                else
                {
                    firstHalf = ticket.Substring(0, 10);
                    secondHalf = ticket.Substring(10, 10);

                    var winningsOne = Regex.Matches(firstHalf, winningPattern);
                    var winningsTwo = Regex.Matches(secondHalf, winningPattern);

                    CheckWinnings(winningsOne, winningsTwo, output, ticket);
                }

                firstHalf = string.Empty;
                secondHalf = string.Empty;
                output = string.Empty;
            }
        }

        //Проверява и връща печалбите.
        static void CheckWinnings(MatchCollection winningsOne, MatchCollection winningsTwo, string output, string ticket)
        {
            var winnings = 0;

            foreach (Match one in winningsOne)
            {
                foreach (Match two in winningsTwo)
                {
                    if ((one.Value.Contains(two.Value) || two.Value.Contains(one.Value))
                        && (one.Value.Length >= 6 && two.Value.Length >= 6)
                        && (one.Value.Length == 10 && two.Value.Length == 10))
                    {

                        output = "ticket \"" + ticket + "\" - " + Math.Min(one.Length, two.Length) + one.Value[0] + " Jackpot!";
                        winnings++;
                        Print(output);
                    }
                    else if ((one.Value.Contains(two.Value) || two.Value.Contains(one.Value))
                             && (one.Value.Length >= 6 && two.Value.Length >= 6))
                    {
                        output = "ticket \"" + ticket + "\" - " + Math.Min(one.Length, two.Length) + one.Value[0];
                        winnings++;
                        Print(output);
                    }
                }
            }

            if (winnings == 0) 
            {
                output = "ticket \"" + ticket + "\" - no match";
                Print(output);
            }
        }

        //Отпечатва резултатите от проверката.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}