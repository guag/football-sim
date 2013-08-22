using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class WideReceiverTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new WideReceiver();
        }

        #endregion

        private WideReceiver _sut;

        [Test]
        public void Max_Height_Is_78()
        {
            Assert.That(_sut.MaxHeight, Is.EqualTo(78));
        }

        [Test]
        public void Max_Weight_Is_250()
        {
            Assert.That(_sut.MaxWeight, Is.EqualTo(250));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(_sut.MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_170()
        {
            Assert.That(_sut.MinWeight, Is.EqualTo(170));
        }

        [Test]
        public void Name_Is_Wide_Receiver()
        {
            Assert.That(_sut.Name, Is.EqualTo("Wide Receiver"));
        }

        [Test]
        public void ShortName_Is_Wr()
        {
            Assert.That(_sut.ShortName, Is.EqualTo("WR"));
        }

        [Test]
        public void Type_Is_Wide_Receiver()
        {
            Assert.That(_sut.Type, Is.EqualTo(PositionType.WideReceiver));
        }
    }
}