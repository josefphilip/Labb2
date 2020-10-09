using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace ShapeGen
{
    class Program
    {
        static void Main(string[] args)
        {

            float triangletotalcirc = 0.0f;
            float averageareaallshapes = 0.0f;
            float largest3dvolume = 0.0f;

            List<Shape> shapegens = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                shapegens.Add(Shape.GenerateShape());
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("20 random shapes with randomly generated numbers");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Shape shape in shapegens)
            {
                Console.WriteLine($"{shape}");
            }

            foreach (Shape shape in shapegens)
            {
                if (shape is Triangle triangle)
                {
                    triangletotalcirc += triangle.Circumference;
                }

                if (shape is Shape3D volumeshape)
                {
                    if (volumeshape.Volume > largest3dvolume)
                    {
                        largest3dvolume = volumeshape.Volume;
                    }
                }
                averageareaallshapes += shape.Area / shapegens.Count;
            }


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Sum of triangle circumference:{triangletotalcirc:0.0}.");
            Console.WriteLine($"Average area of all shapes:{averageareaallshapes:0.0}.");
            Console.WriteLine($"Largest Shape3D volume:{largest3dvolume:0.0}.");
            Console.WriteLine();

            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Extra assignment");
            foreach (Vector2 v in t)
            {
                Console.Write(v + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();





        }
    }
}