//-----------------------------------------------------------------------
// <copyright file="HomeControllerTest.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Web.Tests.Controllers
{
    using System.Web.Mvc;
    using App.Web.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
