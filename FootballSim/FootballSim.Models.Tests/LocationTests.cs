using NUnit.Framework;

namespace FootballSim.Models.Tests
{
    [TestFixture]
    public class LocationTests : BaseTestFixture
    {
        [Test]
        public void City_Test()
        {
            const string city = "Ronkonkoma";
            var sut = new Location {City = city};

            Assert.That(sut.City, Is.EqualTo(city));
        }

        [Test]
        public void State_Test()
        {
            const string state = "NY";
            var sut = new Location {State = state};

            Assert.That(sut.State, Is.EqualTo(state));
        }

        [Test]
        public void ToString_Returns_Orlando_Fl()
        {
            var sut = new Location {City = "Orlando", State = "FL"};
            Assert.That(sut.ToString(), Is.EqualTo("Orlando, FL"));
        }

        [Test]
        public void ToString_Returns_Ronkonkoma_Ny()
        {
            var sut = new Location {City = "Ronkonkoma", State = "NY"};
            Assert.That(sut.ToString(), Is.EqualTo("Ronkonkoma, NY"));
        }
    }
}