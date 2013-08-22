using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class HighCaliberTests : BaseTestFixture
    {
        [Test]
        public void MaxValue_Is_95()
        {
            Assert.That(new HighCaliber().MaxValue, Is.EqualTo(95));
        }

        [Test]
        public void MinValue_Is_70()
        {
            Assert.That(new HighCaliber().MinValue, Is.EqualTo(70));
        }

        [Test]
        public void ToString_Test()
        {
            Assert.That(new HighCaliber().ToString(), Is.EqualTo("High"));
        }
    }
}