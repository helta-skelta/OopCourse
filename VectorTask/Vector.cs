namespace VectorTask
{
    internal class Vector
    {
        private double[]? components;

        public double[]? Components
        {
            get => components;
            set => components = value is null || value.Length == 0 ? throw new ArgumentNullException(nameof(value), "Vector is null or void") : value;
        }

        public double this[int index]
        {
            get => components![index];
            set => components![index] = value;
        }

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Длинна массива должна быть > 0", nameof(n));
            }

            Components = new double[n];
        }

        public Vector(Vector vector) : this(vector!.Components!.Length, vector.Components) { }

        public Vector(double[] components) : this(components.Length, components) { }

        public Vector(int n, double[] components) : this(n)
        {
            for (int i = 0; i < components?.Length; ++i)
            {
                Components![i] = components[i];
            }
        }

        public int GetSize() => Components!.Length;

        public override string ToString()
        {
            return $"{{{String.Join(", ", Components!)}}}";
        }

        public void Joining(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), "Vector is null");
            }

            if (components!.Length < vector!.components!.Length)
            {
                Array.Resize(ref this.components, vector!.components!.Length);
            }
            else if (components!.Length < vector!.components!.Length)
            {
                Array.Resize(ref vector!.components, components!.Length);
            }

            for (int i = 0; i < components!.Length; ++i)
            {
                components![i] += vector!.components![i];
            }
        }

        public void Subtraction(Vector vector)
        {
            if (vector is null)
            {
                return;
            }

            if (vector!.components!.Length <= components!.Length)
            {
                for (int i = 0; i < vector.components!.Length; ++i)
                {
                    components[i] -= vector.components![i];
                }
            }
            else
            {
                for (int i = 0; i < components!.Length; ++i)
                {
                    components[i] -= vector.components![i];
                }
            }
        }

        public void ScalarMultiply(double factor)
        {
            for (int i = 0; i < components!.Length; ++i)
            {
                components[i] *= factor;
            }
        }

        public void Reverse()
        {
            ScalarMultiply(-1);
        }

        public double GetLength()
        {
            double length = 0;

            for (int i = 0; i < components!.Length; ++i)
            {
                length += components[i] * components[i];
            }

            return Math.Sqrt(length);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (obj is null || obj.GetType() != GetType())
            {
                return false;
            }

            Vector vector = (Vector)obj;

            return ToString() == vector.ToString();
        }

        public override int GetHashCode()
        {
            int hash = 0;
            int prime = 31;

            hash = prime * hash + (components != null ? components.GetHashCode() : 0);

            return hash;
        }

        public static Vector Join(Vector a, Vector b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Vector is null");
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b), "Vector is null");
            }

            Vector result = new(a);

            result.Joining(b);

            return result;
        }

        public static Vector Subtract(Vector a, Vector b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Vector is null");
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b), "Vector is null");
            }

            Vector result = new(a);

            result.Subtraction(b);

            return result;
        }

        public static Vector Multiply(Vector a, Vector b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Vector is null");
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b), "Vector is null");
            }

            if (a.components!.Length < b.components!.Length)
            {
                Array.Resize(ref a.components, b.components!.Length);
            }
            else if (a.components.Length < b.components!.Length)
            {
                Array.Resize(ref b.components, a.components.Length);
            }

            Vector result = new(a);

            for (int i = 0; i < a.components!.Length; ++i)
            {
                result[i] *= b[i];
            }

            return result;
        }
    }
}