using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather;
using Weather.Controllers;
using System.Diagnostics.CodeAnalysis;

namespace Weather.Tests.Controllers
{
  [TestClass]
  [ExcludeFromCodeCoverage]
  public class TemperatureControllerTest
  {

    [TestMethod]
    public void TemperaturePut()
    {
      TemperatureController controller = new TemperatureController();

      controller.Put("location", "98.6");
    }

    [TestMethod]
    public void TemperatureGet()
    {
      TemperatureController controller = new TemperatureController();
      controller.Put("location", "98.6");

      string result = controller.Get("location");

      Assert.AreEqual("98.6", result);
    }

    [TestMethod]
    public void TemperatureGet2Locations()
    {
      TemperatureController controller = new TemperatureController();
      controller.Put("location1", "98.6");
      controller.Put("location2", "32.0");

      string result1 = controller.Get("location1");
      string result2 = controller.Get("location2");

      Assert.AreEqual("98.6", result1);
      Assert.AreEqual("32.0", result2);
    }

    [TestMethod]
    public void TemperatureGetEmptyLocation()
    {
      TemperatureController controller = new TemperatureController();

      string results = controller.Get(string.Empty);
      
      Assert.IsTrue(string.IsNullOrEmpty(results));
    }

    [TestMethod]
    public void TemperatureGetUnknownLocation()
    {
      TemperatureController controller = new TemperatureController();

      string results = controller.Get("!!!");

      Assert.IsTrue(string.IsNullOrEmpty(results));
    }
  }
}
