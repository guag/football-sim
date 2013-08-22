using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class FreeSafetyTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new FreeSafety();
        }

        #endregion

        private FreeSafety _sut;

        [Test]
        public void Name_Is_Free_Safety()
        {
            Assert.That(_sut.Name, Is.EqualTo("Free Safety"));
        }

        [Test]
        public void ShortName_Is_Fs()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("FS"));
        }

        [Test]
        public void Type_Is_Free_Safety()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.FreeSafety));
        }
    }
}