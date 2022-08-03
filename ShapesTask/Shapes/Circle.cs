using System;

namespace ShapesTask
{
    internal class Circle : IShape
    {
        private double radius;

        private const double epsilon = 1.0e-10;
        private const int prime = 23;

        public double Radius
        {
            get => radius;
            set => radius = (radius <= epsilon) ? value : 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public double GetHeight()
        {
            return radius * 2;
        }

        public double GetPerimeter()
        {
            return Math.PI * radius * 2;
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

            Circle circle = (Circle)o;

            return radius == circle.radius;
        }

        public override int GetHashCode()
        {
            int hash = 1;

            hash = prime * hash + radius.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Окружность с радиусом {radius}.";
        }
    }
}