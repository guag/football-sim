using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class AverageCaliberTests : BaseTestFixture
    {
        [Test]
        public void MaxValue_Is_85()
        {
            Assert.That(new AverageCaliber().MaxValue, Is.EqualTo(85));
        }

        [Test]
        public void MinValue_Is_60()
        {
            Assert.That(new AverageCaliber().MinValue, Is.EqualTo(60));
        }

        [Test]
        public void ToString_Test()
        {
            Assert.That(new AverageCaliber().ToString(), Is.EqualTo("Average"));
        }
    }
}