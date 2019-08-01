using System;

namespace HttpSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer(8080);
            server.StartServer();
            Console.WriteLine("Done...!");
        }
    }
}
