using System;

namespace ShapesTask
{
    internal class Rectangle : IShape
    {
        private double height;
        private double width;

        private const double epsilon = 1.0e-10;
        private const int prime = 29;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get => height;

            set
            {
                if (height <= epsilon)
                {
                    throw new ArgumentException("Длинна стороны должна быть больше 0!", nameof(Height));
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Width
        {
            get => width;

            set
            {
                if (width <= epsilon)
                {
                    throw new ArgumentException("Длинна стороны должна быть больше 0!", nameof(Width));
                }
                else
                {
                    width = value;
                }
            }
        }

        public double GetArea()
        {
            return height * width;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetPerimeter()
        {
            return (width + height) * 2;
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

            Rectangle rectangle = (Rectangle)o;

            return height == rectangle.height && width == rectangle.width;
        }

        public override int GetHashCode()
        {
            int hash = 1;

            hash = prime * hash + height.GetHashCode();
            hash = prime * hash + width.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {height}, {width}.";
        }
    }
}