using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouBeen;
using PlacesYouBeen.Models;
using System;

namespace PlacesYouBeen.Tests
{
  [TestClass]
  public class CityTests
  {
    // public void Dispose();
    // { 
    //     City.ClearAll();
    // }

  [TestMethod]
  public void CityConstructor_CreateInstanceOfCity_City()
  {
    Citys newCitys = new Citys("San Francisco", 1, "Golden Gate Bridge");
    Assert.AreEqual(typeof(Citys), newCitys.GetType());
  }
    [TestMethod]
    public void GetCity_ReturnsCityName_String()
    {
      string cityName = "San Francisco";
      Citys  city = new Citys(cityName, 1, "Golden Gate Bridge");
      string result = city.CityName;
      Assert.AreEqual(cityName, result);
    }
  } 
}
