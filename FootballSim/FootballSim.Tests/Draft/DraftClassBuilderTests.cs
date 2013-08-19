using System;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using Moq;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Draft
{
    [TestFixture]
    public class DraftClassBuilderTests : BaseTestFixture
    {
        [Test]
        public void Create_1000_Players_Of_A_Certain_Position()
        {
            var playerBuilder = Mock<IPlayerBuilder>();
            var draftFactory = Mock<IDraftClassFactory>();
            var sut = new DraftClassBuilder(
                playerBuilder.Object,
                draftFactory.Object,
                Mock<IDraftBirthDateGenerator>().Object);
            playerBuilder.Setup(p => p.Build()).Returns(It.IsAny<Player>());
            var draft = new DraftClass();
            draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = sut.Build(2013, 1000);
            playerBuilder.Verify(p => p.Build(), Times.Exactly(1000));
            draftFactory.Verify(d => d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(1000));
        }

        [Test]
        public void Create_500_Players_Of_A_Certain_Position()
        {
            var playerBuilder = Mock<IPlayerBuilder>();
            var draftFactory = Mock<IDraftClassFactory>();
            var sut = new DraftClassBuilder(
                playerBuilder.Object,
                draftFactory.Object,
                Mock<IDraftBirthDateGenerator>().Object);
            playerBuilder.Setup(p => p.Build()).Returns(It.IsAny<Player>());
            var draft = new DraftClass();
            draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = sut.Build(2013, 500);
            playerBuilder.Verify(p => p.Build(), Times.Exactly(500));
            draftFactory.Verify(d => d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(500));
        }

        [Test]
        public void Build_Sets_Player_BirthDates()
        {
            var generator = StrictMock<IDraftBirthDateGenerator>();
            var factory = Mock<IDraftClassFactory>();
            var builder = Mock<IPlayerBuilder>();
            var sut = new DraftClassBuilder(
                builder.Object,
                factory.Object,
                generator.Object);
            var player = new Player();
            builder.Setup(b => b.Build()).Returns(player);
            var date = DateTime.Now;
            generator.Setup(g => g.Generate(2013)).Returns(date);
            var draft = new DraftClass();
            factory.Setup(f => f.Create(2013)).Returns(draft);

            sut.Build(2013, 1);
            generator.Verify(g=>g.Generate(2013));
            Assert.That(player.BirthDate, Is.EqualTo(date));
        }
    }
}