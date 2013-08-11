using FootballSim.Models;
using FootballSim.Models.Players;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class HometownCacheTests : BaseTestFixture
    {
        [Test]
        public void Call_Twice_But_Load_Hometowns_Once()
        {
            var loader = Mock<ICsvFileLoader>();
            var random = Mock<IRandomService>();
            var sut = new HometownCache(loader.Object, random.Object);
            var loc = new[] { "Holbrook", "NY" };
            var hometowns = new[] { new string[2], loc };
            loader.Setup(l => l.Hometowns).Returns(hometowns);
            random.Setup(r => r.GetRandom(2)).Returns(0);

            sut.GetRandomHometown();
            Location result = sut.GetRandomHometown();
            loader.Verify(l => l.Hometowns, Times.Once());
            random.Verify(r => r.GetRandom(2));
        }

        [Test]
        public void Get_First_Hometown()
        {
            var loader = Mock<ICsvFileLoader>();
            var random = Mock<IRandomService>();
            var sut = new HometownCache(loader.Object, random.Object);
            var loc = new[] { "Holbrook", "NY" };
            var hometowns = new[] { loc, new string[2] };
            loader.Setup(l => l.Hometowns).Returns(hometowns);
            random.Setup(r => r.GetRandom(2)).Returns(0);

            Location result = sut.GetRandomHometown();
            loader.Verify(l => l.Hometowns);
            random.Verify(r => r.GetRandom(2));
            Assert.That(result, Is.EqualTo(new Location { City = "Holbrook", State = "NY" }));
        }

        [Test]
        public void Get_Second_Hometown()
        {
            var loader = Mock<ICsvFileLoader>();
            var random = Mock<IRandomService>();
            var sut = new HometownCache(loader.Object, random.Object);
            var loc = new[] { "Holbrook", "NY" };
            var hometowns = new[] { new string[2], loc, new string[2] };
            loader.Setup(l => l.Hometowns).Returns(hometowns);
            random.Setup(r => r.GetRandom(3)).Returns(1);

            Location result = sut.GetRandomHometown();
            loader.Verify(l => l.Hometowns);
            random.Verify(r => r.GetRandom(3));
            Assert.That(result, Is.EqualTo(new Location { City = "Holbrook", State = "NY" }));
        }
    }
}