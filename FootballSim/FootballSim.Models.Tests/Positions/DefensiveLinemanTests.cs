using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensiveLinemanTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new DefensiveTackle().MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_350()
        {
            Assert.That(new DefensiveTackle().MaxWeight, Is.EqualTo(350));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new DefensiveTackle().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_270()
        {
            Assert.That(new DefensiveTackle().MinWeight, Is.EqualTo(270));
        }

        [Test]
        public void Name_Is_Defensive_Tackle()
        {
            Assert.That(new DefensiveTackle().Name, Is.EqualTo("Defensive Tackle"));
        }

        [Test]
        public void RatingTypes_Test()
        {
            var sut = new DefensiveTackle();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.PassRushing));
        }
    }
}