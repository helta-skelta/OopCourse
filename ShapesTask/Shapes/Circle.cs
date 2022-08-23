namespace ShapesTask.Shapes
{
    internal class Circle : IShape
    {
        private double radius;
        private const double Epsilon = 1.0e-10;

        public double Radius
        {
            get => radius;
            set => radius = value <= Epsilon
                ? throw new ArgumentException("Радиус круга должен быть больше 0!", nameof(value))
                : value;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetHeight()
        {
            return radius * 2;
        }

        public double GetPerimeter()
        {
            return Math.PI * radius * 2;
        }

        public double GetWidth()
        {
            return radius * 2;
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

            Circle circle = (Circle)o;

            return radius == circle.radius;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int prime = 23;

            hash = prime * hash + radius.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return $"Окружность с радиусом {radius}.";
        }
    }
}