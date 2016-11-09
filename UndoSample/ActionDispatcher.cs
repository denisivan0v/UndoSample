using System.Collections.Generic;
using UndoSample.Commands;

namespace UndoSample
{
    public sealed class ActionDispatcher
    {
        private readonly Stack<ICommand> _undoCommands = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            _undoCommands.Push(command);
            command.Run();
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_undoCommands.Count != 0)
                {
                    var command = _undoCommands.Pop();
                    command.Undo();
                }
            }
        }
    }
}