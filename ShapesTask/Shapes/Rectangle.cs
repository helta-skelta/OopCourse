namespace ShapesTask.Shapes
{
    internal class Rectangle : IShape
    {
        private double height;
        private double width;
        private const double Epsilon = 1.0e-10;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get => height;
            set => height = value <= Epsilon ? throw new ArgumentException("Длинна стороны должна быть больше 0!", nameof(value)) : value;
        }

        public double Width
        {
            get => width;

            set => width = value <= Epsilon && value >= -Epsilon ? throw new ArgumentException("Длинна стороны должна быть больше 0!", nameof(value)) : value;
        }

        public double GetArea()
        {
            return height * width;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetPerimeter()
        {
            return (width + height) * 2;
        }

        public double GetWidth()
        {
            return width;
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

            Rectangle rectangle = (Rectangle)o;

            return height == rectangle.height && width == rectangle.width;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int Prime = 29;

            hash = Prime * hash + height.GetHashCode();
            hash = Prime * hash + width.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {height}, {width}.";
        }
    }
}