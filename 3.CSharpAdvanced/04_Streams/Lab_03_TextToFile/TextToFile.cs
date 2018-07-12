using System;
using System.IO;
using System.Text;

namespace Lab_03_TextToFile
{
    public class TextToFile
    {
        public static void Main(string[] args)
        {
            ReceivingText();
        }

        //Receiving text from the console.
        public static void ReceivingText()
        {
            var text = Console.ReadLine();
            RecordTheString(text);
        }

        //Records the incoming string to the file.
        public static void RecordTheString(string text)
        {
            var fileStream = new FileStream("../../log.txt", FileMode.Create);

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}