using System.Collections.Generic;

namespace Logger
{
    public class ConsoleAppender : IAppender
    {
        private List<ILayout> layout;
        private string reportLevel;

        public string ReportLevel
        {
            get
            {
                return this.reportLevel;
            }
            set
            {
                this.reportLevel = value;
            }
        }

        public List<ILayout> Layout
        {
            get
            {
                return this.layout;

            }
            set
            {
                this.layout = value;
            }
        }
        public string Append(string date, string message, string level)
        {


            //  if(level=="Info" || level == "Error")
            //  {
            //      return this.Layout.Find(l=>l.GetType().Name=="SimpleLayout").Formating(date, message, level);
            //  }
            //  else if (level == "Critical" || level == "Fatal")
            //  {
            //      return this.Layout.Find(l => l.GetType().Name == "XmlLayout").Formating(date, message, level);
            //  }
            //

            if (level == "Critical" || level == "Fatal" || level == "Error")
            {
                return this.Layout.Find(l => l.GetType().Name == "SimpleLayout").Formating(date, message, level);
            }

            return string.Empty;

        }

        public ConsoleAppender(ILayout simpleLayout)
        {
            this.Layout = new List<ILayout>();
        }

    }
}
