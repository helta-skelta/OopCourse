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
    }
}