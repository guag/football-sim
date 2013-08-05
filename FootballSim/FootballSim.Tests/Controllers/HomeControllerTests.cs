using System;
using System.Diagnostics;
using System.Web.Mvc;
using FootballSim.Controllers;
using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests : BaseTestFixture
    {
        [Test]
        public void DraftTest()
        {
            var draftFactory = Mock<IDraftClassFactory>();
            var sut = new HomeController(draftFactory.Object);
            var year = new DateTime(2013, 1, 1);
            var draftClass = new DraftClass(null, year);
            draftFactory.Setup(d => d.Create(year, 1000)).Returns(draftClass);

            var result = sut.DraftClass() as ViewResult;
            draftFactory.Verify(d => d.Create(year, 1000));
            Debug.Assert(result != null, "result != null");
            Assert.That(result.Model, Is.EqualTo(draftClass));
        }
    }
}
