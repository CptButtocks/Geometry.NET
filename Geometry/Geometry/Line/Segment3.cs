using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Line
{
    public class Segment3
    {
        private Point3 _start { get; set; }
        private Point3 _end { get; set; }

        private float _length { get; set; }

        public Point3 Start
        {
            get { return _start; }
            set
            {
                _start = value;
                _length = _start.Distance(_end);
            }
        }
        public Point3 End
        {
            get { return _end; }
            set
            {
                _end = value;
                _length = _start.Distance(_end);
            }
        }

        public float Length => _length;

        public Segment3(Point3 start, Point3 end)
        {
            _start = start;
            _end = end;
            _length = _start.Distance(_end);
        }
    }
}
