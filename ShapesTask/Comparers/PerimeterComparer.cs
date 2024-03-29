﻿using ShapesTask.Shapes;

namespace ShapesTask.Comparers
{
    internal class PerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null)
            {
                throw new ArgumentNullException(nameof(shape1));
            }

            if (shape2 is null)
            {
                throw new ArgumentNullException(nameof(shape2));
            }

            return shape1.GetPerimeter().CompareTo(shape2.GetPerimeter());
        }
    }
}