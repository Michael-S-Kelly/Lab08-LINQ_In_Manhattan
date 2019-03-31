using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQInManhattan.Classes
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    /// <summary>
    /// Collects the Properties data for PropertyTypes
    /// </summary>
    public class Properties
    {
        [JsonProperty(PropertyName = "Zip")]
        public string Zip { get; set; }
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "Borough")]
        public string Borough { get; set; }
        [JsonProperty(PropertyName = "Neighborhood")]
        public string Neighborhood { get; set; }
        [JsonProperty(PropertyName = "County")]
        public string County { get; set; }
    }
}
