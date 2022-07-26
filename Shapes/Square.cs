using System;

namespace Shapes
{
    internal class Square : IShape
    {
        private double width;

        public Square(double width)
        {
            this.width = width;
        }

        public double Width
        {
            get => width;

            set
            {
                if (width <= IShape.EPSILON)
                {
                    Console.WriteLine("Длинна стороны должна быть больше 0!");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double GetArea()
        {
            return width * width;
        }

        public double GetHeight()
        {
            return width;
        }

        public double GetPerimeter()
        {
            return width * 4;
        }

        public double GetWidth()
        {
            return width;
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

            Square other = (Square)o;

            return width == other.width;
        }

        public override int GetHashCode()
        {
            int prime = 27;
            int hash = 1;

            hash = (prime * hash) + width.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Квадрат со стороной {width}.";
        }
    }
}