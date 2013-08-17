using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class PlayerRatingsBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Test()
        {
            var ratings = StrictMock<IRatingGenerator>();
            var sut = new PlayerRatingsBuilder(ratings.Object);
            var position = new Quarterback();
            const Caliber caliber = Caliber.Scrub;
            var player = new Player {Position = position, Caliber = caliber};
            ratings.Setup(r => r.Generate(caliber)).Returns(It.IsAny<Rating>());

            sut.Build(player);
            ratings.Verify(r => r.Generate(caliber), Times.Exactly(position.RatingTypes.Count));
            Assert.That(player.Ratings.Count, Is.EqualTo(position.RatingTypes.Count));
            foreach (var rating in player.Ratings)
            {
                Assert.That(position.RatingTypes, Contains.Item(rating.Key));
            }
        }
    }
}