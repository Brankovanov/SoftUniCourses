

namespace Logger
{
    public interface ILogger
    {

        IAppender Appender { get; set; }

        string Error(string date, string message);
        string Info(string date, string message);
        string Fatal(string date, string message);
        string Critical(string date, string message);
        string Warning(string date, string messag);
    }
}
