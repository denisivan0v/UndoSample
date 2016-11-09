namespace UndoSample.Commands
{
    public interface ICommand
    {
        void Run();
        void Undo();
    }
}