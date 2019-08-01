namespace HttpSocketServer
{
    class Request
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Host { get; set; }
        public Request(string type, string url, string host)
        {
            Type = type;
            Url = url;
            Host = host;
        }
        public static Request GetRequest(string request)
        {
            string[] token = request.Split(' ', '\n');
            string type = token[0];
            string url = token[1];
            string host = token[4];
            return new Request(type, url, host);
        }
    }
}