using System.Diagnostics;
using System.Web.Mvc;
using FootballSim.Controllers;
using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Controllers
{
    //[TestFixture]
    public class HomeControllerTests : BaseTestFixture
    {
        // TODO: test this when I figure out what to put here.

        //[Test]
        //public void DraftTest()
        //{
        //    var draftFactory = Mock<IDraftClassFactory>();
        //    var sut = new HomeController(draftFactory.Object);
        //    const int year = 2009;
        //    var draftClass = new DraftClass { Year = year };
        //    draftFactory.Setup(d => d.Create(year, 1000)).Returns(draftClass);

        //    var result = sut.DraftClass(2009) as ViewResult;
        //    draftFactory.Verify(d => d.Create(year, 1000));
        //    Debug.Assert(result != null, "result != null");
        //    Assert.That(result.Model, Is.EqualTo(draftClass));
        //}
    }
}
