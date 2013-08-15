using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class OffensiveLinemanTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new Guard().MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_380()
        {
            Assert.That(new Guard().MaxWeight, Is.EqualTo(380));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new Guard().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_280()
        {
            Assert.That(new Guard().MinWeight, Is.EqualTo(280));
        }

        [Test]
        public void RatingTypes_Test()
        {
            var sut = new Guard();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.RunBlocking));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.PassBlocking));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Guard().Side, Is.EqualTo(Side.Offense));
        }
    }
}