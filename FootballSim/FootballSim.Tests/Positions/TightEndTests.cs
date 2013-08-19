using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class TightEndTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new TightEnd();
        }

        #endregion

        private TightEnd _sut;

        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(_sut.MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_280()
        {
            Assert.That(_sut.MaxWeight, Is.EqualTo(280));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(_sut.MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_220()
        {
            Assert.That(_sut.MinWeight, Is.EqualTo(220));
        }

        [Test]
        public void Name_Is_Tight_End()
        {
            Assert.That(_sut.Name, Is.EqualTo("Tight End"));
        }

        [Test]
        public void ShortName_Is_Te()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("TE"));
        }

        [Test]
        public void Type_Is_Tight_End()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.TightEnd));
        }
    }
}