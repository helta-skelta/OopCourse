using System;

namespace Shapes
{
    internal interface IShape
    {
        public const double EPSILON = 1.0e-10;
        double GetWidth();
        double GetHeight();
        double GetArea();
        double GetPerimeter();
    }
}