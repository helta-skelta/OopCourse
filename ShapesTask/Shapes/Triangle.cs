﻿namespace ShapesTask.Shapes
{
    internal class Triangle : IShape
    {
        public double X1 { get; set; }

        public double Y1 { get; set; }

        public double X2 { get; set; }

        public double Y2 { get; set; }

        public double X3 { get; set; }

        public double Y3 { get; set; }

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
            double side1Length = GetSideLength(X1, Y1, X2, Y2);
            double side2Length = GetSideLength(X2, Y2, X3, Y3);
            double side3Length = GetSideLength(X3, Y3, X1, Y1);

            double triangleSemiPerimeter = (side1Length + side2Length + side3Length) / 2;

            double area = Math.Sqrt(triangleSemiPerimeter * (triangleSemiPerimeter - side1Length) *
                (triangleSemiPerimeter - side2Length) * (triangleSemiPerimeter - side3Length));

            return area;
        }

        public double GetHeight()
        {
            return Math.Max(Y3, Math.Max(Y1, Y2)) - Math.Min(Y3, Math.Min(Y1, Y2));
        }

        public double GetWidth()
        {
            return Math.Max(X3, Math.Max(X1, X2)) - Math.Min(X3, Math.Min(X1, X2));
        }

        public double GetPerimeter()
        {
            double side1Length = GetSideLength(X1, Y1, X2, Y2);
            double side2Length = GetSideLength(X2, Y2, X3, Y3);
            double side3Length = GetSideLength(X3, Y3, X1, Y1);

            return side1Length + side2Length + side3Length;
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

            return X1 == triangle.X1 && X2 == triangle.X2 && X3 == triangle.X3
                && Y1 == triangle.Y1 && Y2 == triangle.Y2 && Y3 == triangle.Y3;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int prime = 37;

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
            return $"Треугольник с координатами вершин: ({X1}; {Y1}), ({X2}; {Y2}), ({X3}; {Y3}).";
        }
    }
}