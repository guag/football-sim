using FootballSim.Models;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class RatingsBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Test()
        {
            var random = Mock<IRandomService>();
            var sut = new RatingsBuilder(random.Object);
            var position = new Quarterback();
            var player = new Player {Position = position};
            const int value = 88;
            random.Setup(r => r.GetRandom(50, 100)).Returns(value);

            sut.Build(player);
            random.Verify(r => r.GetRandom(50, 100), Times.Exactly(position.RatingTypes.Count));
            Assert.That(player.Ratings.Count, Is.EqualTo(position.RatingTypes.Count));
            foreach (var rating in player.Ratings)
            {
                Assert.That(position.RatingTypes, Contains.Item(rating.Key));
            }
        }
    }
}