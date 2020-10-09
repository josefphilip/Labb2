using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {

        private readonly Vector2 center;
        private readonly Vector2 size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            size.X = width;
            size.Y = width;
        }

        public override Vector3 Center => new Vector3(center, 0);
        public override float Area => Math.Abs((size.X * size.Y));
        public override float Circumference => Math.Abs((size.X * 2 + size.Y * 2));

        public bool IsSquare => size.X == size.Y;


        public override string ToString()
        {
            if (IsSquare)
            {
                return $"Square @({center.X:0.0}, {Center.Y:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}";
            }
            else
            {
                return $"Rectangle @({center.X:0.0}, {center.Y:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}";
            }
        }

    }



}

