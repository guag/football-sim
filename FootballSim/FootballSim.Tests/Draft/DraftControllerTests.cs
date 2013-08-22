using System.Collections.Generic;
using FootballSim.Draft;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Tests;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Draft
{
    [TestFixture]
    public class DraftControllerTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _draftBuilder = Mock<IDraftClassBuilder>();
            _sut = new DraftController(_draftBuilder.Object);
            _p1 = new Player();
            _p2 = new Player();
            _p3 = new Player();
            _players = new[] {_p1, _p2, _p3};
        }

        #endregion

        private DraftController _sut;
        private Mock<IDraftClassBuilder> _draftBuilder;
        private IList<Player> _players;
        private Player _p1;
        private Player _p2;
        private Player _p3;

        [Test]
        public void Create_Builds_New_Draft_Class()
        {
            var draft = new DraftClass {Year = 2006};
            _draftBuilder.Setup(d => d.Build(2006, 50)).Returns(draft);

            var result = _sut.CreateDraft(2006, 50);
            _draftBuilder.Verify(d => d.Build(2006, 50));
            Assert.That(result, Is.EqualTo(draft));
        }

        [Test]
        public void Sort_Returns_Default_Sort()
        {
            var result = _sut.SortPlayers(_players);
        }
    }
}