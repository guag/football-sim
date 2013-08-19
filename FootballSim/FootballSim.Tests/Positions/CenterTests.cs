using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class CenterTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Center();
        }

        #endregion

        private Center _sut;

        [Test]
        public void ShortName_Is_C()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("C"));
        }

        [Test]
        public void Type_Is_Center()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Center));
        }
    }
}