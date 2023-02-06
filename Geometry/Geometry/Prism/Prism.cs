using Geometry.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Prism
{
    public class Prism
    {
        private Triangle3 _face { get; set; }
        private float _depth { get; set; }

        public Prism(Triangle3 face, float depth)
        {
            _face = face;
            _depth = depth;
        }
    }
}
