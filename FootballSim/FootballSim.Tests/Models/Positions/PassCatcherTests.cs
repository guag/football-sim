using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PassCatcherTests
    {
        [Test]
        public void RatingTypes_Test()
        {
            var sut = new WideReceiver();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Catching));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.RunBlocking));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.PassBlocking));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.RouteRunning));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new WideReceiver().Side, Is.EqualTo(Side.Offense));
        }
    }
}