using FootballSim.Models;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
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
            factory.Setup(f => f.Create(70)).Returns(rating);

            var result = sut.Generate(cal);
            random.Verify(r => r.GetRandom(cal.MinValue, cal.MaxValue));
            factory.Verify(f => f.Create(70));
            Assert.That(result, Is.EqualTo(rating));
        }
    }
}