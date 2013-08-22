using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class KickerTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new Placekicker().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_240()
        {
            Assert.That(new Placekicker().MaxWeight, Is.EqualTo(240));
        }

        [Test]
        public void Min_Height_Is_68()
        {
            Assert.That(new Placekicker().MinHeight, Is.EqualTo(68));
        }

        [Test]
        public void Min_Weight_Is_160()
        {
            Assert.That(new Placekicker().MinWeight, Is.EqualTo(160));
        }

        [Test]
        public void RatingTypes_Test()
        {
            var sut = new Placekicker();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.KickingPower));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.KickingAccuracy));
        }

        [Test]
        public void Side_Is_Special_Teams()
        {
            Assert.That(new Placekicker().Side, Is.EqualTo(Side.SpecialTeams));
        }
    }
}