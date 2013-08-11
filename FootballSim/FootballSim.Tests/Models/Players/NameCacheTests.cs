using FootballSim.Models;
using FootballSim.Models.Players;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class NameCacheTests : BaseTestFixture
    {
        [Test]
        public void Do_Not_Load_First_Names_Twice_Because_Already_Loaded()
        {
            var loader = StrictMock<ICsvFileLoader>();
            var sut = new NameCache(loader.Object, Mock<IRandomNumberService>().Object);
            loader.Setup(l => l.FirstNames).Returns(new string[10]);

            sut.GetRandomFirstName();
            sut.GetRandomFirstName();
            loader.Verify(l => l.FirstNames, Times.Once());
        }

        [Test]
        public void Do_Not_Load_Last_Names_Twice_Because_Already_Loaded()
        {
            var loader = StrictMock<ICsvFileLoader>();
            var sut = new NameCache(loader.Object, Mock<IRandomNumberService>().Object);
            loader.Setup(l => l.LastNames).Returns(new string[10]);

            sut.GetRandomLastName();
            sut.GetRandomLastName();
            loader.Verify(l => l.LastNames, Times.Once());
        }

        [Test]
        public void Get_Random_First_Name_Second_Item()
        {
            var loader = Mock<ICsvFileLoader>();
            var randomService = Mock<IRandomNumberService>();
            var sut = new NameCache(loader.Object, randomService.Object);
            var names = new[] {"Nicole", "Jacob", "Katie"};
            loader.Setup(l => l.FirstNames).Returns(names);
            randomService.Setup(r => r.GetRandomInt(3)).Returns(1);

            var result = sut.GetRandomFirstName();
            loader.Verify(l => l.FirstNames);
            randomService.Verify(r => r.GetRandomInt(3));
            Assert.That(result, Is.EqualTo("Jacob"));
        }

        [Test]
        public void Get_Random_First_Name_Third_Item()
        {
            var loader = Mock<ICsvFileLoader>();
            var randomService = Mock<IRandomNumberService>();
            var sut = new NameCache(loader.Object, randomService.Object);
            var names = new[] {"Nicole", "Jacob", "Katie"};
            loader.Setup(l => l.FirstNames).Returns(names);
            randomService.Setup(r => r.GetRandomInt(3)).Returns(2);

            var result = sut.GetRandomFirstName();
            loader.Verify(l => l.FirstNames);
            randomService.Verify(r => r.GetRandomInt(3));
            Assert.That(result, Is.EqualTo("Katie"));
        }

        [Test]
        public void Get_Random_Last_Name_Second_Item()
        {
            var loader = Mock<ICsvFileLoader>();
            var randomService = Mock<IRandomNumberService>();
            var sut = new NameCache(loader.Object, randomService.Object);
            var names = new[] {"Paul", "Schmidt", "Guagliardo"};
            loader.Setup(l => l.LastNames).Returns(names);
            randomService.Setup(r => r.GetRandomInt(3)).Returns(1);

            var result = sut.GetRandomLastName();
            loader.Verify(l => l.LastNames);
            randomService.Verify(r => r.GetRandomInt(3));
            Assert.That(result, Is.EqualTo("Schmidt"));
        }

        [Test]
        public void Get_Random_Last_Name_Third_Item()
        {
            var loader = Mock<ICsvFileLoader>();
            var randomService = Mock<IRandomNumberService>();
            var sut = new NameCache(loader.Object, randomService.Object);
            var names = new[] {"Paul", "Schmidt", "Guagliardo"};
            loader.Setup(l => l.LastNames).Returns(names);
            randomService.Setup(r => r.GetRandomInt(3)).Returns(2);

            var result = sut.GetRandomLastName();
            loader.Verify(l => l.LastNames);
            randomService.Verify(r => r.GetRandomInt(3));
            Assert.That(result, Is.EqualTo("Guagliardo"));
        }

        [Test]
        public void No_First_Names()
        {
            var loader = Mock<ICsvFileLoader>();
            var sut = new NameCache(loader.Object, Mock<IRandomNumberService>().Object);
            loader.Setup(l => l.FirstNames).Returns(new string[0]);

            var result = sut.GetRandomFirstName();
            loader.Verify(l => l.FirstNames);
            Assert.That(result, Is.EqualTo(NameCache.EmptyName));
        }

        [Test]
        public void No_Last_Names()
        {
            var loader = Mock<ICsvFileLoader>();
            var sut = new NameCache(loader.Object, Mock<IRandomNumberService>().Object);
            loader.Setup(l => l.LastNames).Returns(new string[0]);

            var result = sut.GetRandomLastName();
            loader.Verify(l => l.LastNames);
            Assert.That(result, Is.EqualTo(NameCache.EmptyName));
        }
    }
}