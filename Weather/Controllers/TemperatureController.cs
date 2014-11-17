using System;
using System.Collections.Generic;
using System.Web.Http;
using Weather.Models;

namespace Weather.Controllers
{
    public class TemperatureController : ApiController
    {
      private List<DataPoint> dataPoints;

      public TemperatureController()
      {
        dataPoints = new List<DataPoint>();
      }

      // PUT api/values/5
      [Route("temp/{location}/{value}")]
      [HttpPut]
      public void Put(string location, string value)
      {
        var point = new DataPoint()
        {
          Location = location,
          ID = dataPoints.Count + 1,
          DateCreated = DateTime.Now,
          Value = value
        };
        dataPoints.Add(point);
      }

      [Route("temp/{location}")]
      [HttpGet]
      public string Get(string location)
      {
        var point = dataPoints.FindLast(p => p.Location == location);
        if (point != null)
        {
          return point.Value;
        }
        return string.Empty;
      }
    }
}
