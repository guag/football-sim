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
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _birthDate = Mock<IDraftBirthDateGenerator>();
            _draftFactory = Mock<IDraftClassFactory>();
            _players = Mock<IPlayerBuilder>();
            _sut = new DraftClassBuilder(
                _players.Object,
                _draftFactory.Object,
                _birthDate.Object);
        }

        #endregion

        private DraftClassBuilder _sut;
        private Mock<IDraftBirthDateGenerator> _birthDate;
        private Mock<IDraftClassFactory> _draftFactory;
        private Mock<IPlayerBuilder> _players;

        [Test]
        public void Build_Sets_Player_BirthDates()
        {
            var player = new Player();
            _players.Setup(b => b.Build()).Returns(player);
            var date = DateTime.Now;
            _birthDate.Setup(g => g.Generate(2013)).Returns(date);
            var draft = new DraftClass();
            _draftFactory.Setup(f => f.Create(2013)).Returns(draft);

            _sut.Build(2013, 1);
            _birthDate.Verify(g => g.Generate(2013));
            Assert.That(player.BirthDate, Is.EqualTo(date));
        }

        [Test]
        public void Create_1000_Players_Of_A_Certain_Position()
        {
            _players.Setup(p => p.Build()).Returns(new Player());
            _birthDate.Setup(b => b.Generate(2013)).Returns(It.IsAny<DateTime>());
            var draft = new DraftClass();
            _draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = _sut.Build(2013, 1000);
            _players.Verify(p => p.Build(), Times.Exactly(1000));
            _draftFactory.Verify(d => d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(1000));
        }

        [Test]
        public void Create_500_Players_Of_A_Certain_Position()
        {
            _players.Setup(p => p.Build()).Returns(new Player());
            _birthDate.Setup(b => b.Generate(2013)).Returns(It.IsAny<DateTime>());
            var draft = new DraftClass();
            _draftFactory.Setup(d => d.Create(2013)).Returns(draft);

            var result = _sut.Build(2013, 500);
            _players.Verify(p => p.Build(), Times.Exactly(500));
            _draftFactory.Verify(d => d.Create(2013));
            Assert.That(result, Is.EqualTo(draft));
            Assert.That(result.Players, Has.Count.EqualTo(500));
        }
    }
}