using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class OutlookGeneratorTests : BaseTestFixture
    {
        [Test]
        public void Returns_BlueChip_If_In_Top_5_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new OutlookGenerator(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(3);

            var result = sut.GenerateCaliber();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.EqualTo(Caliber.BlueChip));
        }

        [Test]
        public void Returns_High_If_In_5_To_20_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new OutlookGenerator(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(15);

            var result = sut.GenerateCaliber();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.EqualTo(Caliber.High));
        }

        [Test]
        public void Returns_Average_If_In_21_To_50_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new OutlookGenerator(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(30);

            var result = sut.GenerateCaliber();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.EqualTo(Caliber.Average));
        }

        [Test]
        public void Returns_Low_If_In_51_To_100_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new OutlookGenerator(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(75);

            var result = sut.GenerateCaliber();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.EqualTo(Caliber.Scrub));
        }
    }
}