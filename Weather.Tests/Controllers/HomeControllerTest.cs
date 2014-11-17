using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather;
using Weather.Controllers;
using System.Diagnostics.CodeAnalysis;

namespace Weather.Tests.Controllers
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    [ExcludeFromCodeCoverage]
    public void Index()
    {
      // Arrange
      HomeController controller = new HomeController();

      // Act
      ViewResult result = controller.Index() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("Home Page", result.ViewBag.Title);
    }
  }
}
