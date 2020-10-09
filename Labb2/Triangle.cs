using System;
using System.Collections;
using System.Numerics;

namespace ShapeLibrary
{
    public class Triangle : Shape2D, IEnumerator, IEnumerable
    {

        private int position = -1;
        private Vector2[] vectorArray = new Vector2[3];
        private readonly Vector2 pos1;
        private readonly Vector2 pos2;
        private readonly Vector2 pos3;
        private float cb;
        private float ca;
        private float ab;


        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {

            this.pos1 = p1;
            this.pos2 = p2;
            this.pos3 = p3;
            vectorArray[0] = p1;
            vectorArray[1] = p2;
            vectorArray[2] = p3;


            // https://www.chilimath.com/lessons/intermediate-algebra/distance-formula/
            // https://www.khanacademy.org/math/geometry/hs-geo-analytic-geometry/hs-geo-distance-and-midpoints/v/distance-formula
            cb = MathF.Sqrt(MathF.Pow(pos3.X - pos2.X, 2) + MathF.Pow(pos3.Y - pos2.Y, 2));
            ca = MathF.Sqrt(MathF.Pow(pos3.X - pos1.X, 2) + MathF.Pow(pos3.Y - pos1.Y, 2));
            ab = MathF.Sqrt(MathF.Pow(pos1.X - pos2.X, 2) + MathF.Pow(pos1.Y - pos2.Y, 2));

        }

        public override Vector3 Center => new Vector3((pos1.X + pos2.X + pos3.X) / 3, (pos1.Y + pos2.Y + pos3.Y) / 3, 0);

        public override float Area => Math.Abs((float)1 / 2 * (pos1.X * (pos2.Y - pos3.Y) + pos2.X * (pos3.Y - pos1.Y) + pos3.X * (pos1.Y - pos2.Y)));

        public override float Circumference => Math.Abs(cb + ca + ab);


        public override string ToString() => $"Triangle @({Center.X:0.0} {Center.Y:0.0}), p1({pos1.X:0.0} {pos1.Y:0.0}), p2({pos2.X:0.0} {pos2.Y:0.0}), p3({pos3.X:0.0} {pos3.Y:0.0})";



        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                try
                {
                    return vectorArray[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            position++;
            return (position < vectorArray.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}