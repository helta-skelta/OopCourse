using System;

namespace ShapesTask
{
    internal class Square : IShape
    {
        private double length;

        private const double epsilon = 1.0e-10;
        private const int prime = 31;

        public Square(double width)
        {
            this.length = width;
        }

        public double Width
        {
            get => length;

            set
            {
                if (length <= epsilon)
                {
                    Console.WriteLine("Длинна стороны должна быть больше 0!");
                }
                else
                {
                    length = value;
                }
            }
        }

        public double GetArea()
        {
            return length * length;
        }

        public double GetHeight()
        {
            return length;
        }

        public double GetPerimeter()
        {
            return length * 4;
        }

        public double GetWidth()
        {
            return length;
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

            Square square = (Square)o;

            return length == square.length;
        }

        public override int GetHashCode()
        {
            int hash = 1;

            hash = prime * hash + length.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Квадрат со стороной {length}.";
        }
    }
}