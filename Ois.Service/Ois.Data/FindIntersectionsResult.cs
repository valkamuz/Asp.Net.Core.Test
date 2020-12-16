using System;
using System.Collections.Generic;

namespace Ois.Data
{
    public class FindIntersectionsResult
    {
        public Guid Guid { get; set; }
        public Curve Curve1 { get; set; }
        public Curve Curve2 { get; set; }
        
        public IList<Point> Intersections { get; set; }
    }
}
