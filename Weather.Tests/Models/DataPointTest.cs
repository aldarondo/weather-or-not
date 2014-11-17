using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather.Models;
using System.Diagnostics.CodeAnalysis;

namespace Weather.Tests.Models
{
  [TestClass]
  [ExcludeFromCodeCoverage]
  public class DataPointTest
  {
    [TestMethod]
    public void GetSetID()
    {
      var point = new DataPoint();
      point.ID = 1234;
      Assert.AreEqual(1234, point.ID);
    }

    [TestMethod]
    public void GetSetLocation()
    {
      var point = new DataPoint();
      point.Location = "Home";
      Assert.AreEqual("Home", point.Location);
    }

    [TestMethod]
    public void GetSetValue()
    {
      var point = new DataPoint();
      point.Value = "98.6";
      Assert.AreEqual("98.6", point.Value);
    }

    [TestMethod]
    public void GetSetDateCreated()
    {
      var point = new DataPoint();
      var date = DateTime.Now;
      point.DateCreated = date;
      Assert.AreEqual(date, point.DateCreated);
    }
  }
}
