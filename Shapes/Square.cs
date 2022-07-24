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
    }
}