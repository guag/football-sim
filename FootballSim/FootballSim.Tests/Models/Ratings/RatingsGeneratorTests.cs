using System.Collections.Generic;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class RatingsGeneratorTests : BaseTestFixture
    {
        [Test]
        public void No_Ratings_Generators_So_Add_Nothing()
        {
            var sut = new RatingsGenerator();
            var player = new Player {Position = new Quarterback()};

            sut.Build(player);
            Assert.That(player.Ratings.Count, Is.EqualTo(0));
        }

        [Test]
        public void Two_Ratings_Generators()
        {
            var sut = new RatingsGenerator();
            var player = new Player {Position = new Quarterback()};
            var gen1 = Mock<IPositionRatingsGenerator>();
            sut.AddRatingsGenerator(PositionType.OutsideLinebacker, gen1.Object);
            var gen2 = Mock<IPositionRatingsGenerator>();
            sut.AddRatingsGenerator(PositionType.Quarterback, gen2.Object);
            var ratings = new Dictionary<RatingType, Rating>
                              {
                                  {RatingType.Passing, new Rating {CurrentValue = 70}},
                                  {RatingType.Speed, new Rating {CurrentValue = 40}}
                              };
            gen2.Setup(g => g.Generate()).Returns(ratings);

            sut.Build(player);
            Assert.That(player.Ratings.Count, Is.EqualTo(2));
            Assert.That(player.Ratings, Is.EquivalentTo(ratings));
        }
    }
}