using System;

namespace Shapes
{
    internal class Circle : IShape
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set => radius = (radius <= IShape.EPSILON) ? value : 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetHeight()
        {
            return radius * 2;
        }

        public double GetPerimeter()
        {
            return Math.PI * (radius * 2);
        }

        public double GetWidth()
        {
            return radius * 2;
        }

        public override bool Equals(object? o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }

            if (o is null || o.GetType() != GetType())
            {
                return false;
            }

            Circle other = (Circle)o;

            return radius == other.radius;
        }

        public override int GetHashCode()
        {
            int prime = 24;
            int hash = 1;

            hash = (prime * hash) + radius.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Окружность с радиусом{radius}.";
        }
    }
}