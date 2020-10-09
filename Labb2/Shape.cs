using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static float numgen()
        {
            Random rNum = new Random();
            return (float)rNum.NextDouble() * 10;
        }

        public static Shape GenerateShape()
        {
            Random rndnum = new Random();
            int randomshape = rndnum.Next(0, 6);

            if (randomshape == 0)
            {
                return new Circle(new Vector2(numgen(), numgen()), numgen());
            }

            if (randomshape == 1)
            {
                return new Rectangle(new Vector2(numgen(), numgen()), new Vector2(numgen(), numgen()));
            }

            if (randomshape == 2)
            {
                return new Triangle(new Vector2(numgen(), numgen()), new Vector2(numgen(), numgen()), new Vector2(numgen(), numgen()));
            }

            if (randomshape == 3)
            {
                return new Cuboid(new Vector3(numgen(), numgen(), numgen()), new Vector3(numgen(), numgen(), numgen()));
            }

            if (randomshape == 4)
            {
                return new Sphere(new Vector3(numgen(), numgen(), numgen()), numgen());
            }

            if (randomshape == 5)
            {
                return new Rectangle(new Vector2(numgen(), numgen()), (numgen()));
            }

            if (randomshape == 6)
            {
                return new Cuboid(new Vector3(numgen(), numgen(), numgen()), numgen());
            }

            return null;
        }

        public static Shape GenerateShape(Vector3 center)
        {
            float pos1x = numgen();
            float pos1y = numgen();
            float pos2x = numgen();
            float pos2y = numgen();
            Random rndNum = new Random();
            int randomShape = rndNum.Next(0, 6);

            if (randomShape == 0)

            {
                return new Circle(new Vector2(center.X, center.Y), numgen());
            }

            if (randomShape == 1)

            {
                return new Rectangle(new Vector2(center.X, center.Y), new Vector2(numgen(), numgen()));
            }

            if (randomShape == 2)

            {
                return new Triangle(new Vector2(pos1x, pos1y), new Vector2(pos2x, pos2y), new Vector2((3 * center.X) - pos1x - pos2x, (3 * center.Y) - pos1y - pos2y));
            }

            if (randomShape == 3)

            {
                return new Cuboid(new Vector3((center.X), (center.Y), center.Z), new Vector3(numgen(), numgen(), numgen()));
            }

            if (randomShape == 4)

            {
                return new Sphere(new Vector3((center.X), (center.Y), center.Z), numgen());
            }

            if (randomShape == 5)

            {
                return new Rectangle(new Vector2(center.X, center.Y), numgen());
            }

            if (randomShape == 6)

            {
                return new Cuboid(new Vector3((center.X), (center.Y), (center.Z)), numgen());
            }


            return null;

        }
    }
}