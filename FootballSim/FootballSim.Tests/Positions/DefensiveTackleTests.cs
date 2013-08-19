using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensiveTackleTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new DefensiveTackle();
        }

        #endregion

        private DefensiveTackle _sut;

        [Test]
        public void Name_Is_Defensive_Tackle()
        {
            Assert.That(_sut.Name, Is.EqualTo("Defensive Tackle"));
        }

        [Test]
        public void ShortName_Is_Dt()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("DT"));
        }

        [Test]
        public void Type_Is_Defensive_Tackle()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.DefensiveTackle));
        }
    }
}