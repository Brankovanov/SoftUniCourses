using System.IO;

namespace Logger
{
    public interface ILayout
    {
        string Formating(string date, string message, string level);
    }
}
