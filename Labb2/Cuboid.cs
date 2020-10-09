using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D

    {

        private readonly Vector3 center;
        private readonly Vector3 size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            size.X = width;
            size.Y = width;
            size.Z = width;
        }


        public override Vector3 Center => center;
        public override float Area => Math.Abs(2 * ((size.X * size.Y) + (size.Z * size.Y) + (size.X * size.Z)));
        public override float Volume => Math.Abs(size.X * size.Y * size.Z);

        public bool IsCube => size.X == size.Y && size.Z == size.X && size.Z == size.Y;

        public override string ToString()
        {
            if (IsCube)
            {
                return $"Cube @({Center.X:0.0}, {Center.Y:0.0}, {Center.Z:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}, l = {size.Z:0.0}";
            }
            else
            {
                return $"Cuboid @({Center.X:0.0}, {Center.Y:0.0}, {Center.Z:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}, l = {size.Z:0.0}";
            }
        }
    }
}
