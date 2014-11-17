using System;

namespace Weather.Models
{
  public class DataPoint
  {
    public int ID { get; set; }
    public string Location { get; set; }
    public string Value { get; set; }
    public DateTime DateCreated { get; set; }
  }
}