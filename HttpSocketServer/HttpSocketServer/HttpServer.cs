using System;
using System.Net;
using System.Net.Sockets;

namespace HttpSocketServer
{
    internal class HttpServer
    {
        private int _port;
        public const string directory = "C:/Users/acharpe/source/repos/HttpSocketServer/HttpSocketServer";
       public const string errorFilePath= "C:/Users/acharpe/source/repos/HttpSocketServer/HttpSocketServer/Error/404.html";
        public HttpServer(int port)
        {
            _port = port;
        }


        public  void StartServer()
        {
            
            ClientHandler handler = new ClientHandler();

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Socket connectionListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                connectionListener.Bind(localEndPoint);
                connectionListener.Listen(100);
                Console.WriteLine("Waiting connection ... ");
                while (true)
                {
                    var client = connectionListener.Accept();
                    handler.HandleClient(client);
                //    client.Close();
                }
                connectionListener.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}