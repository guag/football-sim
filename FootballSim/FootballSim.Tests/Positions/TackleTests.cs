using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class TackleTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Tackle();
        }

        #endregion

        private Tackle _sut;

        [Test]
        public void ShortName_Is_T()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("T"));
        }

        [Test]
        public void Type_Is_Tackle()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Tackle));
        }
    }
}