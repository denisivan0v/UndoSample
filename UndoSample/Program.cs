using System;
using UndoSample.Commands;

namespace UndoSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas();
            Init(canvas);

            var actionDispatcher = new ActionDispatcher();

            Console.WriteLine("Select id of the shape to set color");
            var input = Console.ReadLine();

            var shapeId = Guid.Parse(input);
            var shape = canvas.Peek(shapeId);
            actionDispatcher.Execute(new SetColorCommand(shape, "white"));

            Console.WriteLine("Select id of the shape to move");
            input = Console.ReadLine();

            shapeId = Guid.Parse(input);
            shape = canvas.Peek(shapeId);
            actionDispatcher.Execute(new MoveCommand(shape, 10, 10));

            Console.WriteLine("Select id of the shape to resize");
            input = Console.ReadLine();

            shapeId = Guid.Parse(input);
            shape = canvas.Peek(shapeId);
            actionDispatcher.Execute(new ResizeCommand(shape, 2, 2));

            Console.WriteLine("Select id of the shape to delete");
            input = Console.ReadLine();

            shapeId = Guid.Parse(input);
            actionDispatcher.Execute(new DeleteCommand(shapeId, canvas));
            Console.WriteLine($"Shapes at canvas {string.Join(", ", canvas.List())}");

            Console.WriteLine("How many actions you want to undo?");
            input = Console.ReadLine();

            actionDispatcher.Undo(int.Parse(input));

            Console.WriteLine($"Shapes at canvas {string.Join(", ", canvas.List())}");
        }

        private static void Init(Canvas canvas)
        {
            canvas.Add(Guid.NewGuid(), new Circle(new Point(1, 1), 1));
            canvas.Add(Guid.NewGuid(), new Triangle(new Point(2, 0), new Point(2, 2), new Point(3, 1)));
            canvas.Add(Guid.NewGuid(), new Rectangle(new Point(0, 3), new Point(4, 5)));

            Console.WriteLine($"Shapes added to canvas: {string.Join(", ", canvas.List())}");
        }
    }
}