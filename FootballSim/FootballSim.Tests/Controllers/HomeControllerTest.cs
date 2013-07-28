﻿using System.Diagnostics;
using System.Web.Mvc;
using FootballSim.Controllers;
using NUnit.Framework;

namespace FootballSim.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Debug.Assert(result != null, "result != null");
            Assert.That("Modify this template to jump-start your ASP.NET MVC application.", Is.EqualTo(result.ViewBag.Message));
        }

        [Test]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}
