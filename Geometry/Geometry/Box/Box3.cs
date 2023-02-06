using Geometry.Abstraction;
using Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Box
{
    internal class Box3 : IPositionted3
    {
        private Point3 _position { get; set; }
        private Point3 _min { get; set; }
        private Point3 _max { get; set; }

        private float _width { get; set; }
        private float _height { get; set; }
        private float _depth { get; set; }

        public Point3 Position
        {
            get { return _position; }
            set
            {
                _min = value;
                _max = new(value.X + Width, value.Y + Height, value.Z + Depth);
                _position = value;
            }
        }
        public float Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _max = new(_min.X + _width, _max.Y, _max.Z);
            }
        }
        public float Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _max = new(_max.X, _min.Y + _height, _max.Z);
            }
        }
        public float Depth
        {
            get { return _depth; }
            set
            {
                _depth = value;
                _max = new(_max.X, _max.Y, _min.Z + Depth);
            }
        }

        public Point3 Min
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
        public Point3 Max
        {
            get { return _max; }
            set
            {
                _max = value;
                _width = _max.X - _min.X;
                _height = _max.Y - _min.Y;
            }
        }

        public Box3(Point3 position, float width, float height, float depth)
        {
            _position = position;
            _width = width;
            _height = height;

            _min = new(position.X, position.Y, Position.Z);
            _max = new(position.X + width, position.Y + height, position.Z + depth);
        }

        public Box3(Point3 min, Point3 max)
        {
            _position = min;
            _min = min;
            _max = max;

            _width = _max.X - _min.X;
            _height = _max.Y - _min.Y;
            _depth = _max.Z - _min.Z;
        }
    }
}
