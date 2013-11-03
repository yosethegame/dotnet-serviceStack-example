using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TddReadyTest
    {
        [Test]
        public void NUnitIsReady()
        {
            Assert.That(1 + 1, Is.EqualTo(2));
        }
    }
}

