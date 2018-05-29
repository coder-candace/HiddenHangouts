using HiddenHangouts.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace HiddenHangouts.Utilities
{
    public class LocationFactory
    {
        public static List<Location> GetLocations(dynamic locations)
        {
            var toReturn = new List<Location>();
            foreach (JObject location in locations)
            {
                var locationToAdd = new Location()
                {
                    Id = Guid.NewGuid().ToString(),
                    CreatedByUserId = (int)location["createdByUserId"],
                    Longitude = (float)location["longitude"],
                    Latitude = (float)location["latitude"]
                };
                toReturn.Add(locationToAdd);
            }

            return toReturn;
        }

        public static JArray ParseToJArray(List<Location> locations)
        {
            List<dynamic> locationsToParse = new List<dynamic>();
            foreach (var location in locations)
                locationsToParse.Add(location.ToJObject());

            return JArray.FromObject(locationsToParse);
        }
    }
}
