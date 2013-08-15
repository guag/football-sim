using FootballSim.Models;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class MeasurablesBuilderTests : BaseTestFixture
    {
        [Test]
        public void Get_Random_Measurables_For_Quarterback()
        {
            var randomService = Mock<IRandomService>();
            var sut = new MeasurablesBuilder(randomService.Object);
            var qb = new Quarterback();
            randomService.Setup(r => r.GetRandomWeighted(qb.MinHeight, qb.MaxHeight)).Returns(72);
            randomService.Setup(r => r.GetRandomWeighted(qb.MinWeight, qb.MaxWeight)).Returns(220);
            var result = sut.GenerateMeasurables(qb);

            randomService.Verify(r => r.GetRandomWeighted(qb.MinHeight, qb.MaxHeight));
            randomService.Verify(r => r.GetRandomWeighted(qb.MinWeight, qb.MaxWeight));
            Assert.That(result.Height, Is.EqualTo(72));
            Assert.That(result.Weight, Is.EqualTo(220));
        }

        [Test]
        public void Get_Random_Measurables_For_Tackle()
        {
            var randomService = Mock<IRandomService>();
            var sut = new MeasurablesBuilder(randomService.Object);
            var tackle = new Tackle();
            randomService.Setup(r => r.GetRandomWeighted(tackle.MinHeight, tackle.MaxHeight)).Returns(78);
            randomService.Setup(r => r.GetRandomWeighted(tackle.MinWeight, tackle.MaxWeight)).Returns(320);
            var result = sut.GenerateMeasurables(tackle);

            randomService.Verify(r => r.GetRandomWeighted(tackle.MinHeight, tackle.MaxHeight));
            randomService.Verify(r => r.GetRandomWeighted(tackle.MinWeight, tackle.MaxWeight));
            Assert.That(result.Height, Is.EqualTo(78));
            Assert.That(result.Weight, Is.EqualTo(320));
        }
    }
}