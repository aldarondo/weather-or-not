using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Weather.Controllers
{
    public class TemperatureController : ApiController
    {
      private string locationValue;

      // PUT api/values/5
      [Route("temp/{location}/{value}")]
      [HttpPut]
      public void Put(string location, string value)
      {
        locationValue = value;
      }

      [Route("temp/{location}")]
      [HttpGet]
      public string Get(string location)
      {
        return locationValue;
      }
    }
}
