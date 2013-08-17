using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class RatingFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_Test()
        {
            var sut = new RatingFactory();
            const int val = 22;
            var result = sut.Create(val);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Rating>());
            Assert.That(result.CurrentValue, Is.EqualTo(22));
            Assert.That(result.ProjectedValue, Is.EqualTo(22));
        }
    }
}