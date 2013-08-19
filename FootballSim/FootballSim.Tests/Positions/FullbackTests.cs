using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class FullbackTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Fullback();
        }

        #endregion

        private Fullback _sut;

        [Test]
        public void ShortName_Is_Fullback()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("FB"));
        }

        [Test]
        public void Type_Is_Fullback()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Fullback));
        }
    }
}