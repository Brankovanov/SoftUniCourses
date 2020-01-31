using System;
using System.IO;
using System.Linq;

namespace Lab_06_SliceAfile
{
    class SliceAFile
    {
        static void Main(string[] args)
        {
            using var stream = new FileStream("../../../text.txt", FileMode.OpenOrCreate);

            var parts = 4;

            var length = (int)Math.Ceiling(stream.Length / (decimal)parts);

            var buffer = new byte[length];

            for(var i = 0; i<parts;i++)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);

                if(bytesRead<buffer.Length)
                {
                    buffer = buffer.Take(bytesRead).ToArray();
                }

                using var currentPartStream = new FileStream($"part{i + 1}.txt",FileMode.OpenOrCreate);

                currentPartStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
