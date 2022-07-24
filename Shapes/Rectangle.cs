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
                if (Math.Abs(width) <= IShape.EPSILON)
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
    }
}