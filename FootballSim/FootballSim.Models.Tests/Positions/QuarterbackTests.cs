using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class QuarterbackTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Quarterback();
        }

        #endregion

        private Quarterback _sut;

        [Test]
        public void Max_Height_Is_79()
        {
            Assert.That(_sut.MaxHeight, Is.EqualTo(79));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(_sut.MaxWeight, Is.EqualTo(265));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(_sut.MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_175()
        {
            Assert.That(_sut.MinWeight, Is.EqualTo(175));
        }

        [Test]
        public void Ratings_Test()
        {
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.ThrowingAccuracy));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.ThrowingPower));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Rushing));
        }

        [Test]
        public void ShortName_Is_Qb()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("QB"));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(_sut.Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Type_Is_Quarterback()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Quarterback));
        }
    }
}