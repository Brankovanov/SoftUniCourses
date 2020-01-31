using System.IO;

namespace Lab_01_OddLines
{
    class Startup
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader(@"../../../input.txt");
            using var writer = new StreamWriter(@"../../../output.txt");

            Read(reader, writer);
        }

        private static void Read(StreamReader reader, StreamWriter writer)
        {
            var counter = 0;
            var line = string.Empty;

            while (true)
            {
                line = reader.ReadLine();

                if (counter % 2 != 0)
                {
                    

                    Write(writer, line);
                }

                if (line == null)
                {
                    break;
                }

                counter++;
            }
        }

        private static void Write(StreamWriter writer, string line)
        {
            writer.WriteLine(line);
        }
    }
}
