using System;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    /// <summary>
    /// Collects the overall data from the deserialized Json file
    /// </summary>
    class FeatureCollection
    {
        public string Type { get; set; }
        public List<PropertyType> Features { get; set; }
        
    }
}
