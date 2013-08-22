using FootballSim.Models.Players;
using Moq;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class CollegeCacheTests : BaseTestFixture
    {
        [Test]
        public void Get_Random_College_Returns_Fourth_In_List()
        {
            var randomService = Mock<IRandomService>();
            var loader = Mock<ICsvFileLoader>();
            var sut = new CollegeCache(randomService.Object, loader.Object);

            var colleges = new[] {"SBU", "TCU", "SJC", "BYU"};
            loader.Setup(l => l.Colleges).Returns(colleges);
            randomService.Setup(r => r.GetRandom(4)).Returns(3);

            var result = sut.GetRandomCollege();
            loader.Verify(l => l.Colleges);
            randomService.Setup(r => r.GetRandom(4));
            Assert.That(result, Is.EqualTo("BYU"));
        }

        [Test]
        public void Get_Random_College_Returns_Second_In_List()
        {
            var randomService = Mock<IRandomService>();
            var loader = Mock<ICsvFileLoader>();
            var sut = new CollegeCache(randomService.Object, loader.Object);

            var colleges = new[] {"SBU", "TCU", "SJC"};
            loader.Setup(l => l.Colleges).Returns(colleges);
            randomService.Setup(r => r.GetRandom(3)).Returns(1);

            var result = sut.GetRandomCollege();
            loader.Verify(l => l.Colleges);
            randomService.Setup(r => r.GetRandom(3));
            Assert.That(result, Is.EqualTo("TCU"));
        }

        [Test]
        public void Get_Random_College_Returns_Third_In_List()
        {
            var randomService = Mock<IRandomService>();
            var loader = Mock<ICsvFileLoader>();
            var sut = new CollegeCache(randomService.Object, loader.Object);

            var colleges = new[] {"SBU", "TCU", "SJC"};
            loader.Setup(l => l.Colleges).Returns(colleges);
            randomService.Setup(r => r.GetRandom(3)).Returns(2);

            var result = sut.GetRandomCollege();
            loader.Verify(l => l.Colleges);
            randomService.Setup(r => r.GetRandom(3));
            Assert.That(result, Is.EqualTo("SJC"));
        }

        [Test]
        public void Get_Random_College_Twice_Does_Not_Load_Twice()
        {
            var randomService = Mock<IRandomService>();
            var loader = Mock<ICsvFileLoader>();
            var sut = new CollegeCache(randomService.Object, loader.Object);

            var colleges = new[] {"SBU", "TCU", "SJC"};
            loader.Setup(l => l.Colleges).Returns(colleges);
            randomService.Setup(r => r.GetRandom(3)).Returns(1);

            sut.GetRandomCollege();
            var result = sut.GetRandomCollege();
            loader.Verify(l => l.Colleges, Times.Once());
            randomService.Setup(r => r.GetRandom(3));
            Assert.That(result, Is.EqualTo("TCU"));
        }
    }
}