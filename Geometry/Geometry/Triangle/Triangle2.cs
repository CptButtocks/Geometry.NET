using Geometry.Abstraction;
using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public class Triangle2
    {
        public Point2 VertexA { get; set; }
        public Point2 VertexB { get; set; }
        public Point2 VertexC { get; set; }

        public Triangle2(Point2 vertexA, Point2 vertexB, Point2 vertexC)
        {
            VertexA = vertexA;
            VertexB = vertexB;
            VertexC = vertexC;
        }
    }
}
