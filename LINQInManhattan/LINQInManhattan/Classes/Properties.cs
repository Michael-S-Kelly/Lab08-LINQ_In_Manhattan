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
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "borough")]
        public string Borough { get; set; }
        [JsonProperty(PropertyName = "neighborhood")]
        public string Neighborhood { get; set; }
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }
    }
}
