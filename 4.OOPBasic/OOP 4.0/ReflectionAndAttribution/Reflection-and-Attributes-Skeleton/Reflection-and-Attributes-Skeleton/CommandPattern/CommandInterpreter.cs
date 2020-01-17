
using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private Commands commands;
        public void Read(string args)
        {
            var stringArgs = args.Split(' ');

             this.commands.Execute(stringArgs);


        }


        public CommandInterpreter()
        {

            this.commands = new Commands();
        }
    }
}
