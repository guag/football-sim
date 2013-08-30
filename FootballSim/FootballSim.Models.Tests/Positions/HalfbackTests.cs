using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class HalfbackTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Halfback();
        }

        #endregion

        private Halfback _sut;

        [Test]
        public void ShortName_Is_()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("HB"));
        }

        [Test]
        public void Type_Is_Halfback()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Halfback));
        }
    }
}