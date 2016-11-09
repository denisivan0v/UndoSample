using System;

namespace UndoSample
{
    public sealed class Circle : IShape
    {
        public Circle(Point center, double radius, string color = "red")
        {
            Color = color;
        }

        public string Color { get; private set; }
        public double Width => 0; // logic to calculate width here..
        public double Heigth => 0; // logic to calculate heigth here..

        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine("Circle color set");
        }

        public void Resize(double width, double heigth)
        {
            // changing the radius logic here...
            Console.WriteLine("Circle resized");
        }

        public void Move(double dx, double dy)
        {
            // moving the center point logic here...
            Console.WriteLine("Circle moved");
        }
    }
}