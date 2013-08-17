using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class MeasurablesTests : BaseTestFixture
    {
        [Test]
        public void Height_For_Display_Is_1_Foot()
        {
            var sut = new Measurables {Height = 12};
            Assert.That(sut.HeightForDisplay, Is.EqualTo("1'0\""));
        }

        [Test]
        public void Height_For_Display_Is_6_Feet_2_Inches()
        {
            var sut = new Measurables {Height = 74};
            Assert.That(sut.HeightForDisplay, Is.EqualTo("6'2\""));
        }

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