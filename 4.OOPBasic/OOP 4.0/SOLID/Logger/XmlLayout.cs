
using System;

namespace Logger
{
    public class XmlLayout:ILayout
    {
       
            public string Formating(string date, string message, string level)
            {
                return $"<log> " +
                $"{Environment.NewLine} <date> {date} </date> " +
                $"{Environment.NewLine} <level> {level} </level> " +
                $"{Environment.NewLine} <message> {message} </message> " +
                $"{Environment.NewLine} </log>";
            }

    }
}
