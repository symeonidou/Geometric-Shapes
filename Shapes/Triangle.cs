﻿using System;
using System.Collections;
using System.Numerics;
using Shapes;

namespace ShapeLibary
{
    public class Triangle : Shape2D, IEnumerable, IEnumerator
    {
        private readonly Vector2[] _arraylist;
        private readonly Vector2 _point1;
        private readonly Vector2 _point2;
        private readonly Vector2 _point3;
        private int _index = -1;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            _point1 = p1;
            _point2 = p2;
            _point3 = p3;
            _arraylist = new[] { p1, p2, p3 };
        }

        public override float Circumference
        {
            get
            {
                return MathF.Sqrt(MathF.Pow(_point1.X - _point2.X, 2) + MathF.Pow(_point1.Y - _point2.Y, 2)) +
                MathF.Sqrt(MathF.Pow(_point2.X - _point3.X, 2) + MathF.Pow(_point2.Y - _point3.Y, 2))
                + MathF.Sqrt(MathF.Pow(_point3.X - _point1.X, 2) + MathF.Pow(_point3.Y - _point1.Y, 2));
            }
        }
        public override Vector3 Center
        {
            get
            {
                var x = (_point1.X + _point2.X + _point3.X) / 3.00f;
                var y = (_point1.Y + _point2.Y + _point3.Y) / 3.00f;
                return new Vector3(x, y, 0);
            }
        }
        public override float Area
        {
            get
            {
                var a = _point1.X * (_point2.Y - _point3.Y);
                var b = _point2.X * (_point3.Y - _point1.Y);
                var c = _point3.X * (_point1.Y - _point2.Y);
                var sumArea = (a + b + c) / 2.00f;
                return sumArea;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            _index++;
            return _index < _arraylist.Length;
        }
        public void Reset()
        {
            _index = 0;
        }
        public object Current
        {
            get
            {
                return _arraylist[_index];
            }
        }
        public override string ToString()
        {
            return
                $"Triangle @({Center.X:0.00},{Center.Y:0.00}) : p1: ({_point1.X:0.00},{_point1.Y:0.00}) " +
                $"p2: ({_point2.X:0.00},{_point2.Y:0.00}) p3: ({_point3.X:0.00}, {_point3.Y:0.00})";
        }
    }
}