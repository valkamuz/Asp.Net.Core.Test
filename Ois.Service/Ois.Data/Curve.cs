using System.Collections.Generic;

namespace Ois.Data
{
    public class Curve
    {
        public string Name { get; set; }

        public IList<Point> Points { get; set; }
    }
}
