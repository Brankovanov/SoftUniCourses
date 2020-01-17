using System.Collections.Generic;

namespace Logger
{
   public  interface IAppender
    {
        List<ILayout> Layout { get; set; }
        string ReportLevel { get; set; }
        string Append(string date, string message,string level);

    }
}
