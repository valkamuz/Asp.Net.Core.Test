using System;

namespace Ois.Data
{
    public class FindIntersectionsCommand
    {
        public Guid Guid { get; set; }
        public Curve Curve1 { get; set; }
        public Curve Curve2 { get; set; }
    }
}
