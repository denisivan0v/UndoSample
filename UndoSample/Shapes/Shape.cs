using System;

namespace UndoSample
{
    public abstract class Shape : IShape
    {
        protected Shape(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        public abstract string Color { get; }
        public abstract double Width { get; }
        public abstract double Heigth { get; }
        public abstract void SetColor(string color);
        public abstract void Resize(double width, double heigth);
        public abstract void Move(double dx, double dy);

        protected bool Equals(Shape other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Shape) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Shape left, Shape right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Shape left, Shape right)
        {
            return !Equals(left, right);
        }
    }
}