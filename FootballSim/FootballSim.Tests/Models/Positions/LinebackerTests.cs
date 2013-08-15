using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class LinebackerTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new OutsideLinebacker().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_260()
        {
            Assert.That(new OutsideLinebacker().MaxWeight, Is.EqualTo(260));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new OutsideLinebacker().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_225()
        {
            Assert.That(new OutsideLinebacker().MinWeight, Is.EqualTo(225));
        }

        [Test]
        public void RatingTypes_Test()
        {
            var sut = new OutsideLinebacker();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.PassRushing));
        }
    }
}