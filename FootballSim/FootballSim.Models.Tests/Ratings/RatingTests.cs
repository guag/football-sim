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
            Assert.That(new Rating(default(RatingType), 45).CurrentValue, Is.EqualTo(45));
        }

        [Test]
        public void Ctor_Sets_Projected_Value()
        {
            Assert.That(new Rating(default(RatingType), 45).ProjectedValue, Is.EqualTo(45));
        }

        [Test]
        public void Ctor_Sets_Rating_Type()
        {
            Assert.That(new Rating(RatingType.Agility, 45).Type, Is.EqualTo(RatingType.Agility));
        }

        [Test]
        public void Id_Property()
        {
            Assert.That(new Rating {Id = 399}.Id, Is.EqualTo(399));
        }
    }
}