using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Ratings
{
    [TestFixture]
    public class RatingTests : BaseTestFixture
    {
        [Test]
        public void Ctor_Sets_Current_Value()
        {
            Assert.That(new Rating(45).CurrentValue, Is.EqualTo(45));
        }

        [Test]
        public void Ctor_Sets_Projected_Value()
        {
            Assert.That(new Rating(45).ProjectedValue, Is.EqualTo(45));
        }
    }
}