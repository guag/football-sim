using NUnit.Framework;

namespace FootballSim.Models.Tests
{
    [TestFixture]
    public class PasserRatingServiceTests : BaseTestFixture
    {
        [Test]
        public void Rating_Is_103_Point_6_Because_Of_Very_High_Completion_Percentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 325, 2500, 20, 10), Is.EqualTo(103.6));
        }

        [Test]
        public void Rating_Is_107_Point_1_Because_Of_Very_High_Td_Percentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 2500, 200, 10), Is.EqualTo(107.1));
        }

        [Test]
        public void Rating_Is_112_Point_8_Because_Is_Steve_Young()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(461, 324, 3969, 35, 10), Is.EqualTo(112.8));
        }

        [Test]
        public void Rating_Is_58_Point_9_Because_Of_Very_High_Interception_Percentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 2500, 20, 350), Is.EqualTo(58.9));
        }

        [Test]
        public void Rating_Is_64_Because_Of_Very_Low_Completion_Percentage()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 10, 2500, 20, 10), Is.EqualTo(64.0));
        }

        [Test]
        public void Rating_Is_69_Point_3_Because_Of_Very_Low_Yards_Per_Attempt()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(350, 200, 10, 20, 10), Is.EqualTo(69.3));
        }

        [Test]
        public void Rating_Is_Zero_Because_Attempts_Is_Negative()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(-1, 0, 0, 0, 0), Is.EqualTo(0));
        }

        [Test]
        public void Rating_Is_Zero_Because_Attempts_Is_Zero()
        {
            var sut = new PasserRatingService();
            Assert.That(sut.GetRating(0, 0, 0, 0, 0), Is.EqualTo(0));
        }
    }
}