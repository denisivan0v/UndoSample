namespace UndoSample
{
    public interface IShape
    {
        string Color { get; }
        double Width { get; }
        double Heigth { get; }

        void SetColor(string color);
        void Resize(double width, double heigth);
        void Move(double dx, double dy);
    }
}