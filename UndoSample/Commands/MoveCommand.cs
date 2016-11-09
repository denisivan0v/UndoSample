using System;

namespace UndoSample.Commands
{
    public sealed class MoveCommand : ICommand
    {
        private readonly IShape _shape;
        private readonly double _dx;
        private readonly double _dy;

        public MoveCommand(IShape shape, double dx, double dy)
        {
            _shape = shape;
            _dx = dx;
            _dy = dy;
        }

        public void Run()
        {
            _shape.Move(_dx, _dy);
        }

        public void Undo()
        {
            _shape.Move(-_dx, -_dy);
            Console.WriteLine("Move action undone");
        }
    }
}