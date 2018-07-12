using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab_06_SimpleWebServer
{
    public class SimpleWebServer
    {
        public static void Main(string[] args)
        {
            var portNumber = 1337;
            Listen(portNumber);
        }

        //Listen for the webserver requests.
        public static void Listen(int portNumber)
        {
            var tcpListener = new TcpListener(IPAddress.Any, portNumber);
            tcpListener.Start();

            Console.WriteLine($"Listening on port {portNumber}...");

            while (true)
            {
                NetworkStream stream = tcpListener.AcceptTcpClient().GetStream();

                using (stream)
                {
                    byte[] request = new byte[4096];
                    stream.Read(request, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(request));

                    var html = string.Format($"{0}{1}{2}{3} - {4}{2}{1}{0}", "<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);
                    byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
                    stream.Write(htmlBytes, 0, htmlBytes.Length);
                }
            }
        }
    }
}