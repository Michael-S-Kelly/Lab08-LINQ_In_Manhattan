using System;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    /// <summary>
    /// Collects the Geometry data for PropertyTypes
    /// </summary>
    class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}
