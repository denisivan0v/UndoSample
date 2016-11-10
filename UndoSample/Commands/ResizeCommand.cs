using System;

namespace UndoSample.Commands
{
    public sealed class ResizeCommand : ICommand
    {
        private readonly IShape _shape;
        private readonly double _width;
        private readonly double _height;

        private double _oldWidth;
        private double _oldHeigth;

        public ResizeCommand(IShape shape, double width, double height)
        {
            _shape = shape;
            _width = width;
            _height = height;
        }

        public void Run()
        {
            _oldWidth = _shape.Width;
            _oldHeigth = _shape.Heigth;
            _shape.Resize(_width, _height);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing resize action...");
            _shape.Resize(_oldWidth, _oldHeigth);
            Console.WriteLine("Resize action undone");
        }
    }
}