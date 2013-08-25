using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class RatingFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_Test()
        {
            var sut = new RatingFactory();
            const int val = 22;
            const RatingType type = RatingType.Intelligence;
            var result = sut.Create(type, val);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Rating>());
            Assert.That(result.CurrentValue, Is.EqualTo(22));
            Assert.That(result.ProjectedValue, Is.EqualTo(22));
            Assert.That(result.Type, Is.EqualTo(type));
        }
    }
}