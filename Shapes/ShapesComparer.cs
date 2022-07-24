using System;
using System.Collections.Generic;

namespace Shapes
{
    internal class ShapesComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null || shape2 is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            if (shape1.GetArea() > shape2.GetArea())
            {
                return 1;
            }

            if (shape1.GetArea() < shape2.GetArea())
            {
                return -1;
            }

            return 0;
        }
    }
}