namespace ShapesTask.Shapes
{
    internal class Square : IShape
    {
        private double sideLength;
        private const double Epsilon = 1.0e-10;

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double SideLength
        {
            get => sideLength;
            set => sideLength = value <= Epsilon ? throw new ArgumentException("Длинна стороны должна быть больше 0!", nameof(value)) : value;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public double GetHeight()
        {
            return sideLength;
        }

        public double GetPerimeter()
        {
            return sideLength * 4;
        }

        public double GetWidth()
        {
            return sideLength;
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

            Square square = (Square)o;

            return sideLength == square.sideLength;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int Prime = 31;

            hash = Prime * hash + sideLength.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Квадрат со стороной {sideLength}.";
        }
    }
}