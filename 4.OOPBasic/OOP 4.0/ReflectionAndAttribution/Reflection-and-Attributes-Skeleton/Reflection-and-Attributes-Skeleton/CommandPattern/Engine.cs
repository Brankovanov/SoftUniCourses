using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public void Run()
        {
            while(true)
            {
                var input = Console.ReadLine();

                this.commandInterpreter.Read(input);
            }
        }

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
    }
}
