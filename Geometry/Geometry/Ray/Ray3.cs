using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Ray
{
    public class Ray3
    {
        public Point3 Origin { get; set; }
        public Vector3 Direction { get; set; }

        public Ray3(Point3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }
    }
}
