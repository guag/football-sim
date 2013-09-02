using FootballSim.Models.Draft;
using Moq;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Draft
{
    [TestFixture]
    public class DraftClassRepositoryTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _context = Mock<IFootballSimContext>();
            _sut = new DraftClassRepository(_context.Object);
        }

        #endregion

        private DraftClassRepository _sut;
        private Mock<IFootballSimContext> _context;

        [Test]
        public void Add_Adds_To_Context_DraftClasses_Collection()
        {
            var drafts = new InMemoryDbSet<DraftClass>();
            _context.Setup(c => c.DraftClasses).Returns(drafts);
            var draft = new DraftClass();

            _sut.AddDraft(draft);
            _context.Verify(c => c.DraftClasses);
            Assert.That(drafts, Contains.Item(draft));
        }

        [Test]
        public void Add_Saves_Changes()
        {
            _context.Setup(c => c.DraftClasses).Returns(new InMemoryDbSet<DraftClass>());
            _context.Setup(c => c.SaveChanges()).Returns(1);

            _sut.AddDraft(It.IsAny<DraftClass>());
            _context.Verify(c => c.SaveChanges());
        }

        [Test]
        public void Get_Draft_With_Id_48()
        {
            var dc = new DraftClass {Id = 48};
            var drafts = new InMemoryDbSet<DraftClass> {dc, new DraftClass()};
            _context.Setup(c => c.DraftClasses).Returns(drafts);

            var result = _sut.GetDraft(48);
            _context.Verify(c => c.DraftClasses);
            Assert.That(result, Is.EqualTo(dc));
        }

        [Test]
        public void Get_Draft_With_Id_49()
        {
            var dc = new DraftClass {Id = 49};
            var drafts = new InMemoryDbSet<DraftClass> {dc};
            _context.Setup(c => c.DraftClasses).Returns(drafts);

            var result = _sut.GetDraft(49);
            _context.Verify(c => c.DraftClasses);
            Assert.That(result, Is.EqualTo(dc));
        }

        [Test]
        public void Get_Draft_With_Id_50()
        {
            var dc = new DraftClass {Id = 50};
            var drafts = new InMemoryDbSet<DraftClass> {new DraftClass(), dc};
            _context.Setup(c => c.DraftClasses).Returns(drafts);

            var result = _sut.GetDraft(50);
            _context.Verify(c => c.DraftClasses);
            Assert.That(result, Is.EqualTo(dc));
        }
    }
}