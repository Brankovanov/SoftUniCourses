namespace Logger
{
    public class SimpleLayout : ILayout
    {
        public string Formating(string date, string message, string level)
        {  
            return $"{date} - {level} - {message}";
        }
    }
}
