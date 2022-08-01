using System;

namespace ShapesTask
{
    internal class Triangle : IShape
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }

        private const double epsilon = 1.0e-10;
        private const int prime = 37;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;

            Y1 = y1;

            X2 = x2;

            Y2 = y2;

            X3 = x3;

            Y3 = y3;
        }

        public double GetArea()
        {
            double side1 = GetSideLength(X1, Y1, X2, Y2);
            double side2 = GetSideLength(X2, Y2, X3, Y3);
            double side3 = GetSideLength(X3, Y3, X1, Y1);

            double triangleSemiPerimeter = (side1 + side2 + side3) / 2;

            double area = Math.Sqrt(triangleSemiPerimeter * (triangleSemiPerimeter - side1) *
                (triangleSemiPerimeter - side2) * (triangleSemiPerimeter - side3));

            if (area <= epsilon)
            {
                throw new ArgumentException("Точки лежат на одной прямой, площадь равна 0.", nameof(area));
            }

            return area;
        }

        public double GetHeight()
        {
            double max = Y1;
            double min = Y2;

            if (Y1 < Y2)
            {
                max = Y2;
                min = Y1;
            }

            if (max < Y3)
            {
                max = Y3;
            }

            return max - min;
        }

        public double GetPerimeter()
        {
            double side1 = GetSideLength(X1, Y1, X2, Y2);
            double side2 = GetSideLength(X2, Y2, X3, Y3);
            double side3 = GetSideLength(X3, Y3, X1, Y1);

            return side1 + side2 + side3;
        }

        public double GetWidth()
        {
            double max = X1;
            double min = X2;

            if (X1 < X2)
            {
                max = X2;
                min = X1;
            }

            if (max < X3)
            {
                max = X3;
            }

            return max - min;
        }

        private static double GetSideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
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

            Triangle triangle = (Triangle)o;

            return X1 == triangle.X1 && X2 == triangle.X2 && X3 == triangle.X3 && Y1 == triangle.Y1 && Y2 == triangle.Y2 && Y3 == triangle.Y3;
        }

        public override int GetHashCode()
        {
            int hash = 1;

            hash = prime * hash + X1.GetHashCode();
            hash = prime * hash + X2.GetHashCode();
            hash = prime * hash + X3.GetHashCode();
            hash = prime * hash + Y1.GetHashCode();
            hash = prime * hash + Y2.GetHashCode();
            hash = prime * hash + Y3.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Треугольник с координатами сторон : ({X1};{Y1}), ({X2};{Y2}), ({X3};{Y3}).";
        }
    }
}