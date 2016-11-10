using System;

namespace UndoSample.Commands
{
    public sealed class DeleteCommand : ICommand
    {
        private readonly Guid _id;
        private readonly Canvas _canvas;

        private IShape _shape;

        public DeleteCommand(Guid id, Canvas canvas)
        {
            _id = id;
            _canvas = canvas;
        }

        public void Run()
        {
            _shape = _canvas.Peek(_id);
            _canvas.Delete(_id);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing delete action...");
            _canvas.Add(_id, _shape);
            Console.WriteLine("Delete action undone");
        }
    }
}