using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class StrongSafetyTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new StrongSafety();
        }

        #endregion

        private StrongSafety _sut;

        [Test]
        public void Name_Is_Strong_Safety()
        {
            Assert.That(_sut.Name, Is.EqualTo("Strong Safety"));
        }

        [Test]
        public void ShortName_Is_Ss()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("SS"));
        }

        [Test]
        public void Type_Is_Strong_Safety()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.StrongSafety));
        }
    }
}