using NUnit.Framework;

namespace FootballSim.Models.Tests
{
    [TestFixture]
    public class ExtensionMethodsTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _strings = new[] {"Marcos", "Nicole", "Gary", "Apples"};
        }

        #endregion

        private string[] _strings;

        [Test]
        public void Ascending_Order()
        {
            var result = _strings.OrderBy(s => s, "ASC");
            Assert.That(result, Is.EqualTo(new[] {"Apples", "Gary", "Marcos", "Nicole"}));
        }

        [Test]
        public void Ascending_Order_Because_Order_Is_Null()
        {
            var result = _strings.OrderBy(s => s, null);
            Assert.That(result, Is.EqualTo(new[] {"Apples", "Gary", "Marcos", "Nicole"}));
        }

        [Test]
        public void Descending_Order()
        {
            var result = _strings.OrderBy(s => s, "DESC");
            Assert.That(result, Is.EqualTo(new[] {"Nicole", "Marcos", "Gary", "Apples"}));
        }
    }
}