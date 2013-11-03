using System;
using ServiceStack.WebHost.Endpoints;

namespace Yose
{
    public class Global : System.Web.HttpApplication
    {
        public class HelloAppHost : AppHostBase
        {
            public HelloAppHost() : base("Yose Services", typeof(PingService).Assembly)
            {
            }

            public override void Configure(Funq.Container container)
            {
            }
        }

        protected void Application_Start(Object sender, EventArgs e)
        {
            new HelloAppHost().Init();
        }
    }
}

