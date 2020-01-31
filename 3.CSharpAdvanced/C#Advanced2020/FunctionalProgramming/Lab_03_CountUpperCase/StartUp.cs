using System;
using System.Linq;

namespace Lab_03_CountUpperCase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveText();
        }

        private static void ReceiveText()
        {
            var text = Console.ReadLine()
                .Split(new char[] {  ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortWords(text);
        }

        private static void SortWords(string[] text)
        {
            Console.WriteLine(string.Join(Environment.NewLine, text
                .Where(w => w.StartsWith(w[0].ToString().ToUpper()))));
        }
    }
}
