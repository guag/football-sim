using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class CornerbackTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new Cornerback();
        }

        #endregion

        private Cornerback _sut;

        [Test]
        public void ShortName_Is_Cb()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("CB"));
        }

        [Test]
        public void Type_Is_Cornerback()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Cornerback));
        }
    }
}