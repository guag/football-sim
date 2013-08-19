using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class GuardTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Guard();
        }

        #endregion

        private Guard _sut;

        [Test]
        public void ShortName_Is_G()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("G"));
        }

        [Test]
        public void Type_Is_Guard()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Guard));
        }
    }
}