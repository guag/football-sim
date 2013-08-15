using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class WideReceiverTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_80()
        {
            Assert.That(new WideReceiver().MaxHeight, Is.EqualTo(80));
        }

        [Test]
        public void Max_Weight_Is_260()
        {
            Assert.That(new WideReceiver().MaxWeight, Is.EqualTo(260));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new WideReceiver().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_170()
        {
            Assert.That(new WideReceiver().MinWeight, Is.EqualTo(170));
        }

        [Test]
        public void Name_Is_Wide_Receiver()
        {
            Assert.That(new WideReceiver().Name, Is.EqualTo("Wide Receiver"));
        }

        [Test]
        public void Type_Is_Wide_Receiver()
        {
            Assert.That(new WideReceiver().Type, Is.EqualTo(PositionType.WideReceiver));
        }
    }
}