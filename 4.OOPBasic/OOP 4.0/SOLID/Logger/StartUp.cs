using System;
using System.IO;

namespace Logger
{
    public class StartUp
    {
        static void Main()
        {
             ILayout simpleLayout = new SimpleLayout();
            // ILayout xmlLayout = new XmlLayout();
             IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            // ILogger logger = new Logger(consoleAppender);
            //
            // consoleAppender.Layout.Add(simpleLayout);
            // consoleAppender.Layout.Add(xmlLayout);
            //
            // Printer(logger);
            // Writer(logger);

            
           
            consoleAppender.ReportLevel = "Error";

            var logger = new Logger(consoleAppender);

            logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");
        }

        public static void Printer(ILogger logger)
        {         
            Console.WriteLine(logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON."));
            Console.WriteLine(logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered."));
            Console.WriteLine(logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond"));
            Console.WriteLine(logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config"));
        }

        public static void Writer(ILogger logger)
        {
            var writer = new StreamWriter("C:\\Users\\lenovo\\Documents\\Repositories\\4.OOPBasic\\OOP 4.0\\SOLID\\log.txt");

            using (writer)
            {
                writer.WriteLine(logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON."));
                writer.WriteLine(logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered."));
                writer.WriteLine(logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond"));
                writer.WriteLine(logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config"));
            };
        }
    }
}
