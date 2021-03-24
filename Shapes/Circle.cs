using System;
using System.Numerics;

namespace Shapes
{
    public class Circle : Shape2D
    {
        public readonly Vector3 _center;
        public readonly float _radius;
        public Circle(Vector2 center, float radius)
        {
            _center.X = center.X;
            _center.Y = center.Y;
            _center.Z = 0;
            _radius = radius;
        }
        public override float Circumference => 2 * MathF.PI * _radius;
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
                return MathF.Pow(_radius, 2) * MathF.PI;
            }
        }
        public override string ToString()
        {
            return $"Circle @({Center.X:0.00}, {Center.Y:0.00}):r = {_radius:0.00}";
        }
    }
}