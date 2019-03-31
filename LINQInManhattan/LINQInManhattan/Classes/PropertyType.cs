using System;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    /// <summary>
    /// Collects the three basic groups of data for FeatureCollections
    /// </summary>
    class PropertyType
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }
}
