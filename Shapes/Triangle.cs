﻿using System;

namespace Shapes
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
            double triangleSemiPerimeter = GetPerimeter() / 2;

            double area = Math.Sqrt(triangleSemiPerimeter * (triangleSemiPerimeter - GetSide(X1, Y1, X2, Y2)) *
                (triangleSemiPerimeter - GetSide(X2, Y2, X3, Y3)) * (triangleSemiPerimeter - GetSide(X3, Y3, X1, Y1)));

            if (area <= IShape.EPSILON)
            {
                Console.WriteLine("Точки лежат на одной прямой, площадь не считаем.");
                return 0;
            }

            return area;
        }

        public double GetHeight()
        {
            double[] point = { Y1, Y2, Y3 };

            Array.Sort(point);

            return point[2] - point[0];
        }

        public double GetPerimeter()
        {
            double a = GetSide(X1, Y1, X2, Y2);
            double b = GetSide(X2, Y2, X3, Y3);
            double c = GetSide(X3, Y3, X1, Y1);

            return a + b + c;
        }

        public double GetWidth()
        {
            double[] point = { X1, X2, X3 };

            Array.Sort(point);

            return point[2] - point[0];
        }

        private static double GetSide(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}