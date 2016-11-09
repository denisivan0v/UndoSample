using System;

namespace UndoSample.Commands
{
    public sealed class SetColorCommand : ICommand
    {
        private readonly IShape _shape;
        private readonly string _color;

        private string _oldValue;

        public SetColorCommand(IShape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public void Run()
        {
            _oldValue = _shape.Color;
            _shape.SetColor(_color);
        }

        public void Undo()
        {
            _shape.SetColor(_oldValue);
            Console.WriteLine("Set color action undone");
        }
    }
}