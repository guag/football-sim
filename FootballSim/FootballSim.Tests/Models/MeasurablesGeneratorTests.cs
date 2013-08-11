using FootballSim.Models;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class MeasurablesGeneratorTests : BaseTestFixture
    {
        [Test]
        public void Get_Random_Measurables_For_Quarterback()
        {
            var randomService = Mock<IRandomNumberService>();
            var sut = new MeasurablesGenerator(randomService.Object);
            var qb = new Quarterback();
            randomService.Setup(r => r.GetRandomInt(qb.MaxHeight)).Returns(72);
            randomService.Setup(r => r.GetRandomInt(qb.MaxWeight)).Returns(220);
            var result = sut.GetRandomMeasurables(qb);

            randomService.Verify(r => r.GetRandomInt(qb.MaxHeight));
            randomService.Verify(r => r.GetRandomInt(qb.MaxWeight));
            Assert.That(result.Height, Is.EqualTo(72));
            Assert.That(result.Weight, Is.EqualTo(220));
        }

        [Test]
        public void Get_Random_Measurables_For_Tackle()
        {
            var randomService = Mock<IRandomNumberService>();
            var sut = new MeasurablesGenerator(randomService.Object);
            var tackle = new Tackle();
            randomService.Setup(r => r.GetRandomInt(tackle.MaxHeight)).Returns(78);
            randomService.Setup(r => r.GetRandomInt(tackle.MaxWeight)).Returns(320);
            var result = sut.GetRandomMeasurables(tackle);

            randomService.Verify(r => r.GetRandomInt(tackle.MaxHeight));
            randomService.Verify(r => r.GetRandomInt(tackle.MaxWeight));
            Assert.That(result.Height, Is.EqualTo(78));
            Assert.That(result.Weight, Is.EqualTo(320));
        }
    }
}