using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveDataMap.Models
{
    public class LiveDataModel
    {
        // for this example this will be a travellers name
        public string Value1 { get; set; }

        // where this person is on the specified day [Latitude] 
        public double Latitude { get; set; }

        // where this person is on the specified day [Longitude] 
        public double Longitude { get; set; }
    }
}