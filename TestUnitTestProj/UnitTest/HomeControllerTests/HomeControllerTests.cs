using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using TestUnitTestProj.Controllers;

namespace TestUnitTestProj.UnitTest.HomeControllerTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_ReturnsActionResult()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result);
        }
    }
};