using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class ShapesPerimetrComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null || shape2 is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            if (shape1.GetPerimeter() > shape2.GetPerimeter())
            {
                return 1;
            }

            if (shape1.GetPerimeter() < shape2.GetPerimeter())
            {
                return -1;
            }

            return 0;
        }
    }
}