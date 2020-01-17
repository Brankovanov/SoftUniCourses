namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            CommandProccessor proccessor = new CommandProccessor();
            StudentSystem studentSystem = new StudentSystem();

            while (true)
            {
                 proccessor.ParseCommand(studentSystem);
            }
        }
    }
}