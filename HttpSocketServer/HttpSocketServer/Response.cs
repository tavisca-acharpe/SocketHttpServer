using System.IO;
using System.Net.Sockets;
using System.Text;

namespace HttpSocketServer
{
    public class Response
    {
        public void Post(Socket client, string Url)
        {
            string filePath = HttpServer.directory + Url;
            if (!File.Exists(filePath))
            {
                filePath =HttpServer.errorFilePath;
            }
                string body = File.ReadAllText(filePath);
                int bodyContentLength = body.Length;
                string header = "HTTP/1.1 200 OK\r\nContent-Type: text/html charset=utf-8\r\nContent-length: " + bodyContentLength + "\r\n\r\n";
                byte[] responseBody = Encoding.UTF8.GetBytes(header + body);
                client.Send(responseBody);
         }
    }
}