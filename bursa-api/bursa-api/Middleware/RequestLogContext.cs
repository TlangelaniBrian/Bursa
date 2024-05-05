
namespace bursa_api.Middleware
{
    internal class RequestLogContext
    {
        public string RequestId { get; set; }
        public PathString RequestPath { get; set; }
        public string RequestMethod { get; set; } = "GET";
        public string RequestQueryString { get; set; } = string.Empty;
        public object RequestBody { get; set; }
        public string RequestContentType { get; set; } = string.Empty;
        public long? RequestContentLength { get; set; }
        public Dictionary<string, string> RequestHeaders { get; set; } = new Dictionary<string, string>();
        public string RequestIpAddress { get; set; } = string.Empty;
        public DateTime RequestTimestamp { get; set; }
    }
}