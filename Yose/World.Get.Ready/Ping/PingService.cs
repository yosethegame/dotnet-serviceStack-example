using System.Net;
using ServiceStack.ServiceInterface;
using ServiceStack.Common.Web;

namespace Yose
{
    public class PingService : Service
    {
        public object Any(PingRequest request)
        {
            return new HttpResult
            {
                StatusCode = HttpStatusCode.OK,
                ContentType = ContentType.Json,
                Response = new { alive = true }
            };
        }
    }
}

