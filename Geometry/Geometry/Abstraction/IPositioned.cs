using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Abstraction
{
    public interface IPositioned2
    {
        public Point2 Position { get; set; }
    }

    public interface IPositionted3
    {
        public Point3 Position { get; set; }
    }
}
