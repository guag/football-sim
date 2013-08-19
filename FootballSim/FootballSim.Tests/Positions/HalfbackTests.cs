using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class HalfbackTests : BaseTestFixture
    {
        private Halfback _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Halfback();
        }

        [Test]
        public void Type_Is_Halfback()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.Halfback));
        }

        [Test]
        public void ShortName_Is_()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("HB"));
        }
    }
}