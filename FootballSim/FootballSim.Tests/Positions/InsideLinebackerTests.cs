using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class InsideLinebackerTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new InsideLinebacker();
        }

        #endregion

        private InsideLinebacker _sut;

        [Test]
        public void Name_Is_Inside_Linebacker()
        {
            Assert.That(_sut.Name, Is.EqualTo("Inside Linebacker"));
        }

        [Test]
        public void ShortName_Is_Ilb()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("ILB"));
        }

        [Test]
        public void Type_Is_Inside_Linebacker()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.InsideLinebacker));
        }
    }
}