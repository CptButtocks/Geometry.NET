using Geometry.Abstraction;
using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Box
{
    public class Box2 : IPositioned2
    {
        private Point2 _position { get; set; }
        private Point2 _min { get; set; }
        private Point2 _max { get; set; }

        private float _width { get; set; }
        private float _height { get; set; }

        public Point2 Position
        {
            get { return _position; }
            set
            {
                _min = value;
                _max = new(value.X + Width, value.Y + Height);
                _position = value;
            }
        }
        public float Width 
        { 
            get { return _width; } 
            set 
            {
                _width = value;
                _max = new(_min.X + _width, _max.Y);
            } 
        }
        public float Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _max = new(_max.X, _min.Y + _height);
            }
        }

        public Point2 Min
        {
            get { return _min; }
            set
            {
                _position = value;
                _min = value;
                _width = _max.X - _min.X;
                _height = _max.Y - _min.Y;
            }
        }
        public Point2 Max
        {
            get { return _max; }
            set
            {
                _max = value;
                _width = _max.X - _min.X;
                _height = _max.Y - _min.Y;
            }
        }

        public Box2(Point2 position, float width, float height)
        {
            _position = position;
            _width = width;
            _height = height;

            _min = new(position.X, position.Y);
            _max = new(position.X + width, position.Y + height);
        }

        public Box2(Point2 min, Point2 max)
        {
            _position = min;
            _min = min;
            _max = max;

            _width = _max.X - _min.X;
            _height = _max.Y - _min.Y;
        }
    }
}
