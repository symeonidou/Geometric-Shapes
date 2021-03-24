using System;
using System.Numerics;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        public readonly Vector3 _center;
        public readonly Vector2 _size;
        public Rectangle(Vector2 center, Vector2 size)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _size.X   = size.X;
            _size.Y   = size.Y;
        }
        public Rectangle(Vector2 center, float width)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _size.X   = width;
            _size.Y   = width;
        }
        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }
        public override float Area
        {
            get
            {
                return _size.X * _size.Y;
            }
        }
        public override float Circumference
        {
            get
            {
                return 2 * (_size.X + _size.Y);
            }
        }
        public bool Square
        {
            get
            {
                return Math.Abs(_size.Y - _size.X) == 0;
            }
        }
        public override string ToString()
        {
            return Square
                ? $"Square @({Center.X:0.00}, {Center.Y:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}"
                : $"Rectangle @({Center.X:0.00}, {Center.Y:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}";
        }
    }
}