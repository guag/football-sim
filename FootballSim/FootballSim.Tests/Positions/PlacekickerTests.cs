using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class PlacekickerTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Placekicker();
        }

        #endregion

        private Placekicker _sut;

        [Test]
        public void ShortName_Is_K()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("K"));
        }

        [Test]
        public void Type_Is_Kicker()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Kicker));
        }
    }
}