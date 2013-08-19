using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensiveEndTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new DefensiveEnd();
        }

        #endregion

        private DefensiveEnd _sut;

        [Test]
        public void Name_Is_Defensive_End()
        {
            Assert.That(_sut.Name, Is.EqualTo("Defensive End"));
        }

        [Test]
        public void ShortName_Is_De()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("DE"));
        }

        [Test]
        public void Type_Is_Defensive_End()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.DefensiveEnd));
        }
    }
}