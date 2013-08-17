using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Draft
{
    [TestFixture]
    public class DraftClassBuilderTests : BaseTestFixture
    {
        [Test]
        public void Create_1000_Players_Of_A_Certain_Position()
        {
            var playerBuilder = Mock<IPlayerBuilder>();
            var draftFactory = Mock<IDraftClassFactory>();
            var sut = new DraftClassBuilder(playerBuilder.Object, draftFactory.Object);
            playerBuilder.Setup(p => p.Build()).Returns(It.IsAny<Player>());
            var draft = new DraftClass();
            draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = sut.Build(2013, 1000);
            playerBuilder.Verify(p => p.Build(), Times.Exactly(1000));
            draftFactory.Verify(d=>d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(1000));
        }

        [Test]
        public void Create_500_Players_Of_A_Certain_Position()
        {
            var playerBuilder = Mock<IPlayerBuilder>();
            var draftFactory = Mock<IDraftClassFactory>();
            var sut = new DraftClassBuilder(playerBuilder.Object, draftFactory.Object);
            playerBuilder.Setup(p => p.Build()).Returns(It.IsAny<Player>());
            var draft = new DraftClass();
            draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = sut.Build(2013, 500);
            playerBuilder.Verify(p => p.Build(), Times.Exactly(500));
            draftFactory.Verify(d => d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(500));
        }
    }
}