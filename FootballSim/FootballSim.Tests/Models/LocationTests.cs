using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class LocationTests : BaseTestFixture
    {
        [Test]
        public void City_Test()
        {
            const string city = "Ronkonkoma";
            var sut = new Location { City = city };

            Assert.That(sut.City, Is.EqualTo(city));
        }

        [Test]
        public void State_Test()
        {
            const string state = "NY";
            var sut = new Location { State = state };

            Assert.That(sut.State, Is.EqualTo(state));
        }
    }
}
