using HiddenHangouts.Utilities;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace HiddenHangouts.Models
{
    public class Hangout
    {
        public int Id { get; set; }
        public List<Location> Locations { get; set; }
        public int CreatedByUserId { get; set; }

        public Hangout(dynamic hangout)
        {
            Id = hangout.id;
            CreatedByUserId = hangout.createdById;
            Locations = LocationFactory.GetLocations(hangout.locations);
        }

        public dynamic ToJObject(Hangout hangout)
        {
            dynamic hangoutToReturn = new JObject();
            hangoutToReturn.id = Id;
            hangoutToReturn.createdByUserId = CreatedByUserId;
            hangoutToReturn.locations = LocationFactory.ParseToJArray(hangout.Locations);

            return hangoutToReturn;
        }
    }
}