using System.Collections.Generic;
using FootballSim.Draft;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Tests;

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
            _sorter = Mock<IDraftClassPlayerSorter>();
            _repository = Mock<IDraftClassRepository>();
            _sut = new DraftController(_draftBuilder.Object, _sorter.Object,
                                       _repository.Object);
            _players = new[] {new Player(), new Player(), new Player()};
        }

        #endregion

        private Mock<IDraftClassBuilder> _draftBuilder;
        private IList<Player> _players;
        private Mock<IDraftClassRepository> _repository;
        private Mock<IDraftClassPlayerSorter> _sorter;
        private DraftController _sut;

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
            var expected = new[] {new Player(), new Player()};
            _sorter.Setup(s => s.Sort(_players, null, null)).Returns(expected);

            var result = _sut.SortPlayers(_players);
            _sorter.Verify(s => s.Sort(_players, null, null));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_With_Caliber_Expression_And_No_Order_Specified()
        {
            var expected = new[] {new Player(), new Player()};
            _sorter.Setup(s => s.Sort(_players, "Caliber", string.Empty)).Returns(expected);

            var result = _sut.SortPlayers(_players, "Caliber");
            _sorter.Verify(s => s.Sort(_players, "Caliber", string.Empty));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_With_College_Asc_Expression()
        {
            var expected = new[] {new Player(), new Player()};
            _sorter.Setup(s => s.Sort(_players, "College", "ASC")).Returns(expected);

            var result = _sut.SortPlayers(_players, "College ASC");
            _sorter.Verify(s => s.Sort(_players, "College", "ASC"));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sort_With_FullName_Desc_Expression()
        {
            var expected = new[] {new Player(), new Player()};
            _sorter.Setup(s => s.Sort(_players, "FullName", "DESC")).Returns(expected);

            var result = _sut.SortPlayers(_players, "FullName DESC");
            _sorter.Verify(s => s.Sort(_players, "FullName", "DESC"));
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}