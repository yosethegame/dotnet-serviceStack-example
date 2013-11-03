using ServiceStack.ServiceHost;

namespace Yose
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }
}

