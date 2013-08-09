using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class GuardTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Guard()
        {
            Assert.That(new Guard().Name, Is.EqualTo("Guard"));
        }

        [Test]
        public void Type_Is_Guard()
        {
            Assert.That(new Guard().Type, Is.EqualTo(PositionType.Guard));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Guard().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_260()
        {
            Assert.That(new Guard().MinWeight, Is.EqualTo(260));
        }

        [Test]
        public void Max_Weight_Is_400()
        {
            Assert.That(new Guard().MaxWeight, Is.EqualTo(400));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new Guard().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Max_Height_Is_86()
        {
            Assert.That(new Guard().MaxHeight, Is.EqualTo(86));
        }
    }
}
