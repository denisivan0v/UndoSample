using System;
using System.Collections.Generic;
using System.Linq;

namespace UndoSample
{
    public sealed class Canvas
    {
        private readonly Dictionary<Guid, IShape> _shapes = new Dictionary<Guid, IShape>();

        public IReadOnlyCollection<Guid> List() => _shapes.Keys.ToArray();

        public IShape Peek(Guid id)
        {
            IShape shape;
            return _shapes.TryGetValue(id, out shape) ? shape : null;
        }

        public void Add(Guid id, IShape shape) => _shapes.Add(id, shape);

        public void Delete(Guid id) => _shapes.Remove(id);
    }
}