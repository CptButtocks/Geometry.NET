using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Triangle
{
    public class Triangle3
    {
        public Point3 VertexA { get; set; }
        public Point3 VertexB { get; set; }
        public Point3 VertexC { get; set; }

        public Triangle3(Point3 vertexA, Point3 vertexB, Point3 vertexC)
        {
            VertexA = vertexA;
            VertexB = vertexB;
            VertexC = vertexC;
        }
    }
}
