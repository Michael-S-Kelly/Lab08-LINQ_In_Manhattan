using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQInManhattan.Classes
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    /// <summary>
    /// Collects the Geometry data for PropertyTypes
    /// </summary>
    public class Geometry
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "coordinates")]
        public List<double> Coordinates { get; set; }
    }
}
