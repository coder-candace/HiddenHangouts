using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenHangouts.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public List<Location> Locations { get; set; }
        public bool IsFeature { get; set; }


    }
}
