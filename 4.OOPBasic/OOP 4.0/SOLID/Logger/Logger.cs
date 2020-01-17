namespace Logger
{
    public class Logger : ILogger
    {
        private IAppender appender;

        public IAppender Appender
        {
            get
            {
                return this.appender;

            }
            set
            {
                this.appender = value;
            }
        }


        public string Error(string date, string message)
        {
            var level = "Error";
            return this.Appender.Append(date, message,level) ; 
        }

        public string Info(string date, string message)
        {
            var level = "Info";
            return this.Appender.Append( date,  message,level);
        }

        public string Fatal(string date, string message)
        {
            var level = "Fatal";
            return this.Appender.Append(date, message, level);
        }

        public string Critical (string date, string message)
        {
            var level = "Critical";
            return this.Appender.Append(date, message, level);
        }

        public string Warning(string date, string message)
        {
            var level = "Waning";
            return this.Appender.Append(date, message, level);
        }
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

    }
}

