namespace VectorTask
{
    public class Vector
    {
        private double[] components;

        public double this[int index]
        {
            get => components[index];
            set => components[index] = value;
        }

        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"Размер  равен {size}. Размер вектора должен быть больше 0.", nameof(size));
            }

            components = new double[size];
        }

        public Vector(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), $"Вектор равен {vector}.");
            }

            components = new double[vector.components.Length];

            Array.Copy(vector.components, components, vector.components.Length);
        }

        public Vector(double[] components)
        {
            if (components is null)
            {
                throw new ArgumentNullException(nameof(components), $"Массив равен {components}.");
            }

            if (components.Length == 0)
            {
                throw new ArgumentException($"Размер вектора = {components.Length}. Размер вектора должен быть больше 0.", nameof(components));
            }

            this.components = new double[components.Length];

            Array.Copy(components, this.components, components.Length);
        }

        public Vector(int size, double[] components)
        {
            if (components is null)
            {
                throw new ArgumentNullException(nameof(components), $"Массив равен {components}.");
            }

            if (size <= 0)
            {
                throw new ArgumentException($"Размер равен {size}. Размер вектора должен быть больше 0.", nameof(size));
            }

            this.components = new double[size];

            Array.Copy(components, this.components, Math.Min(size, components.Length));
        }

        public int Size => components.Length;

        public override string ToString()
        {
            return $"{{{string.Join(", ", components)}}}";
        }

        public void Add(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), $"Вектор равен {vector}.");
            }

            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, vector.components.Length);
            }

            for (int i = 0; i < vector.components.Length; ++i)
            {
                components[i] += vector[i];
            }
        }

        public void Subtract(Vector vector)
        {
            if (vector is null)
            {
                throw new ArgumentNullException(nameof(vector), $"Вектор равен {vector}.");
            }

            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, vector.components.Length);
            }

            for (int i = 0; i < vector.components.Length; ++i)
            {
                components[i] -= vector[i];
            }
        }

        public void MultiplyByScalar(double factor)
        {
            for (int i = 0; i < components.Length; ++i)
            {
                components[i] *= factor;
            }
        }

        public void Reverse()
        {
            MultiplyByScalar(-1);
        }

        public double GetLength()
        {
            double componentsSquaredSum = 0;

            foreach (double component in components)
            {
                componentsSquaredSum += component * component;
            }

            return Math.Sqrt(componentsSquaredSum);
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

            return components.SequenceEqual(vector.components);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            const int prime = 31;

            foreach (double component in components)
            {
                hash = prime * hash + component.GetHashCode();
            }

            return hash;
        }

        public static Vector GetSum(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), $"Вектор1 равен {vector1}");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), $"Вектор2 равен {vector2}");
            }

            Vector result = new(vector1);

            result.Add(vector2);

            return result;
        }

        public static Vector GetDifference(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), $"Вектор1 равен {vector1}");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), $"Вектор2 равен {vector2}");
            }

            Vector result = new(vector1);

            result.Subtract(vector2);

            return result;
        }

        public static double GetDotProduct(Vector vector1, Vector vector2)
        {
            if (vector1 is null)
            {
                throw new ArgumentNullException(nameof(vector1), $"Вектор1 равен {vector1}");
            }

            if (vector2 is null)
            {
                throw new ArgumentNullException(nameof(vector2), $"Вектор2 равен {vector2}");
            }

            int elementsCount = Math.Min(vector1.components.Length, vector2.components.Length);
            double result = 0;

            for (int i = 0; i < elementsCount; ++i)
            {
                result += vector1[i] * vector2[i];
            }

            return result;
        }
    }
}