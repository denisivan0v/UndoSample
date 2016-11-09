using System;

namespace UndoSample
{
    public sealed class Rectangle : IShape
    {
        public Rectangle(Point x, Point y, string color = "yellow")
        {
            Color = color;
        }

        public string Color { get; private set; }
        public double Width => 0; // logic to calculate width here..
        public double Heigth => 0; // logic to calculate heigth here..

        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine("Rectangle color set");
        }

        public void Resize(double width, double heigth)
        {
            // changing the x, y coordinates logic here...
            Console.WriteLine("Rectangle resized");
        }

        public void Move(double dx, double dy)
        {
            // changing the x, y coordinates logic here...
            Console.WriteLine("Rectangle resized");
        }
    }
}