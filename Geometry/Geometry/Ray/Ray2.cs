using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Ray
{
    public class Ray2
    {
        public Point2 Origin { get; set; }
        public Vector2 Direction { get; set; }

        public Ray2(Point2 origin, Vector2 direction)
        {
            Origin = origin;
            Direction = direction;
        }
    }
}
