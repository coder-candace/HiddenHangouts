using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenHangouts.Models
{
    public class Location
    {
        public string Id { get; set; }
        public int CreatedByUserId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public dynamic ToJObject()
        {
            dynamic location = new JObject();
            location.id = Id;
            location.createdByUserId = CreatedByUserId;
            location.latitude = Latitude;
            location.longitude = Longitude;

            return location;
        }
    }
}
