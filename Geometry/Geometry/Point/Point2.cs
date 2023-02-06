using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Point
{
    public class Point2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float Distance(Point2 other) => MathF.Sqrt(DistanceSquared(other));

        public float DistanceSquared(Point2 other)
        {
            float dxSquared = MathF.Pow(other.X - X, 2);
            float dySquared = MathF.Pow(other.Y - Y, 2);

            return dxSquared + dySquared;
        }
    }
}
