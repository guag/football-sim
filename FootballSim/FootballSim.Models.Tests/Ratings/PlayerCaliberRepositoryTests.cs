using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class PlayerCaliberRepositoryTests : BaseTestFixture
    {
        [Test]
        public void Returns_Average_If_In_21_To_50_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new PlayerCaliberRepository(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(30);

            var result = sut.GetRandom();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.TypeOf<AverageCaliber>());
        }

        [Test]
        public void Returns_BlueChip_If_In_Top_5_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new PlayerCaliberRepository(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(3);

            var result = sut.GetRandom();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.TypeOf<BlueChipCaliber>());
        }

        [Test]
        public void Returns_High_If_In_5_To_20_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new PlayerCaliberRepository(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(15);

            var result = sut.GetRandom();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.TypeOf<HighCaliber>());
        }

        [Test]
        public void Returns_Low_If_In_51_To_100_Percent()
        {
            var random = StrictMock<IRandomService>();
            var sut = new PlayerCaliberRepository(random.Object);
            random.Setup(r => r.GetRandom(0, 100)).Returns(75);

            var result = sut.GetRandom();
            random.Verify(r => r.GetRandom(0, 100));
            Assert.That(result, Is.TypeOf<LowCaliber>());
        }
    }
}