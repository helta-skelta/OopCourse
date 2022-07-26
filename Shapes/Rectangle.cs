using System;

namespace Shapes
{
    internal class Rectangle : IShape
    {
        private double height;
        private double width;

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
                if (height <= IShape.EPSILON)
                {
                    Console.WriteLine("Длинна стороны должна быть больше 0!");
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

            Rectangle other = (Rectangle)o;

            return height == other.height && width == other.width;
        }

        public override int GetHashCode()
        {
            int prime = 25;
            int hash = 1;

            hash = (prime * hash) + height.GetHashCode();
            hash = (prime * hash) + width.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {height},{width}.";
        }
    }
}