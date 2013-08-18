using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class NameBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_First_Name()
        {
            var names = Mock<INameCache>();
            var sut = new NameBuilder(names.Object);
            var player = new Player();
            names.Setup(n => n.GetRandomFirstName()).Returns("Gary");

            sut.Build(player);
            names.Verify(n => n.GetRandomFirstName());
            Assert.That(player.FirstName, Is.EqualTo("Gary"));
        }

        [Test]
        public void Build_Sets_Last_Name()
        {
            var names = Mock<INameCache>();
            var sut = new NameBuilder(names.Object);
            var player = new Player();
            names.Setup(n => n.GetRandomLastName()).Returns("Guagliardo");

            sut.Build(player);
            names.Verify(n => n.GetRandomLastName());
            Assert.That(player.LastName, Is.EqualTo("Guagliardo"));
        }
    }
}