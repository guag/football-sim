using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using Moq;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class PlayerRatingsBuilderTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _ratings = Mock<IRatingGenerator>();
            _sut = new PlayerRatingsBuilder(_ratings.Object);
        }

        #endregion

        private Mock<IRatingGenerator> _ratings;
        private PlayerRatingsBuilder _sut;

        [Test]
        public void Build_Test()
        {
            var position = new Quarterback();
            var caliber = new LowCaliber();
            var player = new Player {Position = position, Caliber = caliber};
            foreach (var type in position.RatingTypes)
            {
                RatingType t = type;
                _ratings.Setup(r => r.Generate(caliber, t)).Returns(new Rating());
            }

            _sut.Build(player);
            foreach (var type in position.RatingTypes)
            {
                RatingType t = type;
                _ratings.Verify(r => r.Generate(caliber, t));
            }
            Assert.That(player.Ratings, Has.Count.EqualTo(position.RatingTypes.Count));
        }
    }
}