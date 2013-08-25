using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class RatingGeneratorTests : BaseTestFixture
    {
        [Test]
        public void Generate_Test()
        {
            var random = StrictMock<IRandomService>();
            var factory = StrictMock<IRatingFactory>();
            var sut = new RatingGenerator(random.Object, factory.Object);
            var cal = new AverageCaliber();
            random.Setup(r => r.GetRandom(cal.MinValue, cal.MaxValue)).Returns(70);
            var rating = new Rating();
            const RatingType type = RatingType.Agility;
            factory.Setup(f => f.Create(type, 70)).Returns(rating);

            var result = sut.Generate(cal, type);
            random.Verify(r => r.GetRandom(cal.MinValue, cal.MaxValue));
            factory.Verify(f => f.Create(type, 70));
            Assert.That(result, Is.EqualTo(rating));
        }
    }
}