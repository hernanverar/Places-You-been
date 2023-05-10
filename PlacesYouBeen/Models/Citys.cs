using System.Collections.Generic;

namespace PlacesYouBeen.Models
{
  public class Citys
  {
    public string CityName { get; set; }
    public int TimesVisited {get; set; }
    public string PlaceVisited {get; set; }
  


    private static List<Citys> _instances = new List<Citys> { };
    public Citys(string citys, int timesvisited, string placevisited)

    {
      CityName = citys;
      TimesVisited = timesvisited;
      PlaceVisited = placevisited;
      _instances.Add(this);
    }
    }
}
