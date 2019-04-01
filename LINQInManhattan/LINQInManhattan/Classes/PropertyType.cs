using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQInManhattan.Classes
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    /// <summary>
    /// Collects the three basic groups of data for FeatureCollections
    /// </summary>
    public class PropertyType
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "geometry")]
        public Geometry Geometry { get; set; }
        [JsonProperty(PropertyName = "properties")]
        public Properties Properties { get; set; }
    }
}
