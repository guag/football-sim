using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class PlayerFactoryTests
    {
        [Test]
        public void Create_Test()
        {
            var sut = new PlayerFactory();
            Assert.That(sut, Is.Not.Null);
            Assert.That(sut.Create(), Is.TypeOf<Player>());
        }
    }
}
