using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class PunterTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Punter();
        }

        #endregion

        private Punter _sut;

        [Test]
        public void ShortName_Is_P()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("P"));
        }

        [Test]
        public void Type_Is_Punter()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Punter));
        }
    }
}