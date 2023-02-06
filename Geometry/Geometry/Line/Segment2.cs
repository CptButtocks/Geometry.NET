using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Line
{
    public class Segment2
    {
        private Point2 _start { get; set; }
        private Point2 _end { get; set; }

        private float _length { get; set; }

        public Point2 Start 
        { 
            get { return _start; } 
            set 
            { 
                _start = value;
                _length = _start.Distance(_end);
            } 
        }
        public Point2 End
        {
            get { return _end; }
            set
            {
                _end = value;
                _length = _start.Distance(_end);
            }
        }

        public float Length => _length;

        public Segment2(Point2 start, Point2 end)
        {
            _start = start;
            _end = end;
            _length = _start.Distance(_end);
        }
    }
}
