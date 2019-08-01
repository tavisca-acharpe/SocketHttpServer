using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace HttpSocketServer
{
    public class ClientHandler
    {
        public void HandleClient(Socket client)
        {
            
            var getData = new byte[1024];
            var numByte = client.Receive(getData);
            string data = Encoding.ASCII.GetString(getData, 0, numByte);
            Request request = Request.GetRequest(data);
            Response response = new Response();
            response.Post(client, request.Url);
        }

        void FileHandling()
        {


        }

    }
}