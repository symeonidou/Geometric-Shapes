using System;
using System.Numerics;
using Shapes;

namespace ShapeLibary
{
    public class Cuboid : Shape3D
    {
        public readonly Vector3 _size;
        public Cuboid(Vector3 center, Vector3 size)
        {
            Center  = center;
            _size.X = size.X;
            _size.Y = size.Y;
            _size.Z = size.Z;
        }
        public Cuboid(Vector3 center, float width)
        {
            Center  = center;
            _size.X = width;
            _size.Y = width;
            _size.Z = width;
        }
        public override Vector3 Center { get; }
        public override float Area
        {
            get
            {
                return 2 * (_size.X + _size.Y + _size.Z);
            }
        }
        public override float Volume
        {
            get
            {
                return _size.X * _size.Y * _size.Z;
            }
        }
        public bool Cube
        {
            get
            {
                return Math.Abs(_size.X - _size.Y) == 0 && Math.Abs(_size.Y - _size.Z) == 0;
            }
        }
        public override string ToString()
        {
            return Cube
                ? $"Cube @({Center.X:0.00}, {Center.Y:0.00},{Center.Z:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}, l = {_size.Z:0.00}"
                : $"Cuboid @({Center.X:0.00}, {Center.Y:0.00},{Center.Z:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}, l = {_size.Z:0.00}";
        }
    }
}