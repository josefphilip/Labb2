using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {

        private readonly Vector3 center;
        private readonly float radius;

        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override Vector3 Center => center;
        public override float Area => Math.Abs((float)(4.0f * Math.PI * radius * radius));
        public override float Volume => Math.Abs((float)(4.0f / 3.0f * (Math.PI) * radius * radius * radius));

        public override string ToString() => $"Sphere  @({center.X:0.0} {center.Y:0.00} {center.Z:0.0}) r = {radius:0.0}";
    }
}
