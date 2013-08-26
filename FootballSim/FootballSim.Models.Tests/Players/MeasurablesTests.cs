using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class MeasurablesTests : BaseTestFixture
    {
        [Test]
        public void Height_Test()
        {
            var sut = new Measurables {Height = 70};
            Assert.That(sut.Height, Is.EqualTo(70));
        }

        [Test]
        public void Weight_Test()
        {
            var sut = new Measurables {Weight = 200};
            Assert.That(sut.Weight, Is.EqualTo(200));
        }
    }
}