using System;
using System.IO;
using System.Text;

namespace Lab_05_InMemoryString
{
    public class InMemoryString
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var text = Console.ReadLine();
            Read(text);
        }

        //Reads the in memory string.
        public static void Read(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream(bytes);

            using (memoryStream)
            {
                int readByte = memoryStream.ReadByte();

                while (readByte != -1)
                {
                    Console.WriteLine((char)readByte);
                    readByte = memoryStream.ReadByte();
                }
            }
        }
    }
}