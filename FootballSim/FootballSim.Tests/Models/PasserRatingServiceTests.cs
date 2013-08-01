using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class PasserRatingServiceTests : BaseTestFixture
    {
        [Test]
        public void RatingIs112Point8BecauseIsSteveYoung()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(461, 324, 3969, 35, 10), Is.EqualTo(112.8));
        }

        [Test]
        public void RatingIs107Point1BecauseOfVeryHighTdPercentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 2500, 200, 10), Is.EqualTo(107.1));
        }

        [Test]
        public void RatingIs103Point6BecauseOfVeryHighCompletionPercentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 325, 2500, 20, 10), Is.EqualTo(103.6));
        }

        [Test]
        public void RatingIs64BecauseOfVeryLowCompletionPercentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 10, 2500, 20, 10), Is.EqualTo(64.0));
        }

        [Test]
        public void RatingIs69Point3BecauseOfVeryLowYardsPerAttempt()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 10, 20, 10), Is.EqualTo(69.3));
        }

        [Test]
        public void RatingIs58Point9BecauseOfVeryHighInterceptionPercentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 2500, 20, 350), Is.EqualTo(58.9));
        }

        [Test]
        public void RatingIsZeroBecauseAttemptsIsZero()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(0, 0, 0, 0, 0), Is.EqualTo(0));
        }

        [Test]
        public void RatingIsZeroBecauseAttemptsIsNegative()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(-1, 0, 0, 0, 0), Is.EqualTo(0));
        }
    }
}
