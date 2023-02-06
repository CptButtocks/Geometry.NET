using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Point
{
    public class Point3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float Distance(Point3 other) => MathF.Sqrt(DistanceSquared(other));

        public float DistanceSquared(Point3 other)
        {
            float dxSquared = MathF.Pow(other.X - X, 2);
            float dySquared = MathF.Pow(other.Y - Y, 2);
            float dzSquared = MathF.Pow(other.Z - Z, 2);

            return dxSquared + dySquared + dzSquared;
        }
    }
}
