using FootballSim.Models.Draft;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Draft
{
    [TestFixture]
    public class DraftClassFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_Draft_Class()
        {
            var sut = new DraftClassFactory();
            const int year = 2013;
            var draft = sut.Create(year);

            Assert.That(draft.Year, Is.EqualTo(year));
        }
    }
}