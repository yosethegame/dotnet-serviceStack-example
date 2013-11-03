using NUnit.Framework;
using Yose;
using ServiceStack.ServiceClient.Web;
using System.Net;

namespace Tests
{
    [TestFixture]
    public class PingServiceTest
    {
        Global.HelloAppHost App;

        [SetUp]
        public void StartApp()
        {
            App = new Global.HelloAppHost();
            App.Init();
            App.Start("http://localhost:7000/");
        }

        [TearDown]
        public void StopApp()
        {
            App.Dispose();
        }

        [Test]
        public void ReturnsTheValueExpectedByTheGame()
        {
            JsonServiceClient client = new JsonServiceClient("http://localhost:7000/");
            var response = client.Get<object>("/ping");

            Assert.That(response, Is.EqualTo("{alive:true}"));
        }
    }
}

