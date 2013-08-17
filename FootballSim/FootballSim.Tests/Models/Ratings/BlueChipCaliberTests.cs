using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class BlueChipCaliberTests : BaseTestFixture
    {
        [Test]
        public void MaxValue_Is_100()
        {
            Assert.That(new BlueChipCaliber().MaxValue, Is.EqualTo(100));
        }

        [Test]
        public void MinValue_Is_80()
        {
            Assert.That(new BlueChipCaliber().MinValue, Is.EqualTo(80));
        }

        [Test]
        public void ToString_Test()
        {
            Assert.That(new BlueChipCaliber().ToString(), Is.EqualTo("Blue Chip"));
        }
    }
}