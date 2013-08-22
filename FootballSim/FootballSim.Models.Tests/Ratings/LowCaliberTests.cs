using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class LowCaliberTests : BaseTestFixture
    {
        [Test]
        public void MaxValue_Is_75()
        {
            Assert.That(new LowCaliber().MaxValue, Is.EqualTo(75));
        }

        [Test]
        public void MinValue_Is_50()
        {
            Assert.That(new LowCaliber().MinValue, Is.EqualTo(50));
        }

        [Test]
        public void ToString_Test()
        {
            Assert.That(new LowCaliber().ToString(), Is.EqualTo("Low"));
        }
    }
}