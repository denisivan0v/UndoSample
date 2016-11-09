using System;

namespace UndoSample
{
    public sealed class Triangle : IShape
    {
        public Triangle(Point x, Point y, Point z, string color = "green")
        {
            Color = color;
        }

        public string Color { get; private set; }
        public double Width => 0; // logic to calculate width here..
        public double Heigth => 0; // logic to calculate heigth here..

        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine("Triangle color set");
        }

        public void Resize(double width, double heigth)
        {
            // changing the x, y, z coordinates logic here...
            Console.WriteLine("Triangle resized");
        }

        public void Move(double dx, double dy)
        {
            // changing the x, y, z coordinates logic here...
            Console.WriteLine("Triangle resized");
        }
    }
}