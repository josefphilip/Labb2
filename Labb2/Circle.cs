using System;
using System.Numerics;
namespace ShapeLibrary
{
    public class Circle : Shape2D
    {

        private readonly Vector2 center;
        private readonly float radius;

        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }


        public override Vector3 Center => new Vector3(center, 0);
        public override float Area => Math.Abs((float)(Math.PI * radius * radius));
        public override float Circumference => Math.Abs((float)(2 * Math.PI * radius));

        public override string ToString() => $"Circle  @{center.X:0.0} {center.Y:0.00} r = {radius:0.0}";


    }
}
