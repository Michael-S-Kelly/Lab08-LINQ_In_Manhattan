using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    /// <summary>
    /// Collects the overall data from the deserialized Json file
    /// </summary>
    public class FeatureCollection
    {
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "Features")]
        public List<PropertyType> Features { get; set; }
        
    }
}
