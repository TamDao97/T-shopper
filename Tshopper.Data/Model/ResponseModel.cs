using System.Collections.Generic;

namespace Tshopper.Infrastructure
{
    public class Response
    {
        public string TraceId { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }

    public class Response<T> : Response where T : class
    {
        public List<T> Data { get; set; }
    }
}
