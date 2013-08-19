using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class OutsideLinebackerTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new OutsideLinebacker();
        }

        #endregion

        private OutsideLinebacker _sut;

        [Test]
        public void Name_Is_Outside_Linebacker()
        {
            Assert.That(_sut.Name, Is.EqualTo("Outside Linebacker"));
        }

        [Test]
        public void ShortName_Is_Olb()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("OLB"));
        }

        [Test]
        public void Type_Is_Outside_Linebacker()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.OutsideLinebacker));
        }
    }
}