using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather;
using Weather.Controllers;

namespace Weather.Tests.Controllers
{
  [TestClass]
  public class TemperatureControllerTest
  {

    [TestMethod]
    public void TemperaturePut()
    {
      // Arrange
      TemperatureController controller = new TemperatureController();

      //Act
      controller.Put("location", "98.6");
    }

    [TestMethod]
    public void TemperatureGet()
    {
      // Arrange
      TemperatureController controller = new TemperatureController();
      controller.Put("location", "98.6");

      //Act
      string result = controller.Get("location");

      Assert.AreEqual("98.6", result);
    }
  }
}
