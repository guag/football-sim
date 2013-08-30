using System;
using FootballSim.Models.Players;
using Moq;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class DraftBirthDateGeneratorTests : BaseTestFixture
    {
        [Test]
        public void Set_BirthDate_To_June_23_1986()
        {
            Mock<IRandomService> random = StrictMock<IRandomService>();
            var sut = new DraftBirthDateGenerator(random.Object);
            random.Setup(r => r.GetRandom(1984, 1989)).Returns(1986);
            random.Setup(r => r.GetRandom(1, 13)).Returns(6);
            random.Setup(r => r.GetRandom(1, 31)).Returns(23);

            DateTime result = sut.Generate(2009);
            random.Verify(r => r.GetRandom(1984, 1989));
            random.Verify(r => r.GetRandom(1, 13));
            random.Verify(r => r.GetRandom(1, 31));
            Assert.That(result, Is.EqualTo(new DateTime(1986, 6, 23)));
        }

        [Test]
        public void Set_BirthDate_To_May_20_1984()
        {
            Mock<IRandomService> random = StrictMock<IRandomService>();
            var sut = new DraftBirthDateGenerator(random.Object);
            random.Setup(r => r.GetRandom(1981, 1986)).Returns(1984);
            random.Setup(r => r.GetRandom(1, 13)).Returns(5);
            random.Setup(r => r.GetRandom(1, 32)).Returns(20);

            DateTime result = sut.Generate(2006);
            random.Verify(r => r.GetRandom(1981, 1986));
            random.Verify(r => r.GetRandom(1, 13));
            random.Verify(r => r.GetRandom(1, 32));
            Assert.That(result, Is.EqualTo(new DateTime(1984, 5, 20)));
        }
    }
}